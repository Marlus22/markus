using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging; // For working with images
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    public partial class UserForm : Form
    {
        private OleDbConnection conn;

        public UserForm()
        {
            InitializeComponent();
            SetRoundedEdges(cafe, 80); // Adjust 20 for different corner radius
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\clare\source\repos\LoginForm\LoginForm\bin\Debug\Account.accdb");
            
        }




        private void SetRoundedEdges(PictureBox pictureBox, int cornerRadius)
        {
            // Create a rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            int width = pictureBox.Width;
            int height = pictureBox.Height;

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Top-left corner
            path.AddArc(width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Top-right corner
            path.AddArc(width - cornerRadius, height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom-right corner
            path.AddArc(0, height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom-left corner
            path.CloseAllFigures();

            // Apply the path as the region for the PictureBox
            pictureBox.Region = new Region(path);
        }



        void GetUsers()
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Users", conn))
            {
                try
                {
                    conn.Open();

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving users: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            GetUsers();

        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userIdTextBox.Text) || string.IsNullOrWhiteSpace(fullNameTextBox.Text) || string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                 string.IsNullOrWhiteSpace(Roletextbox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                 string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
         

         

            using (OleDbCommand cmd = new OleDbCommand(@"INSERT INTO Users (ID, Fullname, Username, Role, Email, [Password] ) VALUES (@id, @fn, @un, @r, @e, @p)", conn))
            {
                cmd.Parameters.AddWithValue("@id", userIdTextBox.Text);
                cmd.Parameters.AddWithValue("@fn", fullNameTextBox.Text);
                cmd.Parameters.AddWithValue("@un", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@r", Roletextbox.Text);
                cmd.Parameters.AddWithValue("@e", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@p", passwordTextBox.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Inserted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting user: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                GetUsers();
            }
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            fullNameTextBox.Clear();
            usernameTextBox.Clear();
            Roletextbox.Clear();
            emailTextBox.Clear();
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();

        }



        private void EditButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) || string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
        string.IsNullOrWhiteSpace(Roletextbox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text) ||
        string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string userId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            string query = "UPDATE Users SET Fullname=@fn, Username=@un, Role=@r, Email=@e, [Password]=@p WHERE ID=@id";
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fn", fullNameTextBox.Text);
                cmd.Parameters.AddWithValue("@un", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@r", Roletextbox.Text);
                cmd.Parameters.AddWithValue("@e", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@p", passwordTextBox.Text);
                cmd.Parameters.AddWithValue("@id", userId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                GetUsers();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fullNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                usernameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Roletextbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                emailTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                passwordTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InventButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoffeeForm CoffeeForm = new CoffeeForm();
            CoffeeForm.ShowDialog();
        }

        private void DashButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm DashboardForm = new DashboardForm();
            DashboardForm.ShowDialog();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm UserForm = new UserForm();
            UserForm.ShowDialog();
        }

        private void POSButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            POSForm POSForm = new POSForm();
            POSForm.ShowDialog();
        }

        private void APButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCoffeeForm AddCoffeeForm = new AddCoffeeForm();
            AddCoffeeForm.ShowDialog();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryForm HistoryForm = new HistoryForm();
            HistoryForm.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Clear any stored user data (if applicable)
                // For example:
                // Session.Clear(); // If you're using a session management system

                this.Close();

                loginForm loginForm = new loginForm();
                loginForm.Show();
            }
        }

       
    }
}