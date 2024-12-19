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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    public partial class InventoryForm : Form
    {
        private OleDbConnection conn;
     
        public InventoryForm()
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

        void GetIngredients()
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Ingredients", conn))
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
                    MessageBox.Show("Error retrieving Ingredients: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            GetIngredients();


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Automatically fill the InventoryDate textbox with the current date and time
            InDatextBox.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Assuming you have a method to get the current username
                string currentUsername = GetCurrentUsername(); // Implement this method to retrieve the username

            // Automatically fill the ItextBox with the username
            ItextBox.Text = currentUsername;

            if (string.IsNullOrWhiteSpace(PIDTextBox.Text) || string.IsNullOrWhiteSpace(IngTextBox.Text) ||
         string.IsNullOrWhiteSpace(QtextBox.Text) || string.IsNullOrWhiteSpace(STextBox.Text) ||
         string.IsNullOrWhiteSpace(LtextBox.Text) || string.IsNullOrWhiteSpace(ItextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Ingredients (ID, IngredientsName, Quantity, Supplier, Location, Inventorer, InventoryDate, ExpirationDate) VALUES (@id, @i, @q, @s, @l, @in, @InDa, @ED)", conn))
            {
                cmd.Parameters.AddWithValue("@id", PIDTextBox.Text);
                cmd.Parameters.AddWithValue("@i", IngTextBox.Text);
                cmd.Parameters.AddWithValue("@q", QtextBox.Text);
                cmd.Parameters.AddWithValue("@s", STextBox.Text);
                cmd.Parameters.AddWithValue("@l", LtextBox.Text);
                cmd.Parameters.AddWithValue("@in", ItextBox.Text);
                cmd.Parameters.AddWithValue("@InDa", InDatextBox.Text);
                cmd.Parameters.AddWithValue("@ED", expicker.Value); // Use DateTimePicker value

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ingredient Inserted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting ingredient: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                GetIngredients();
            }
        }

        private string GetCurrentUsername()
        {
            // This is a placeholder. Replace it with your actual logic to retrieve the username.
            return "Sam_02"; // Replace with actual username retrieval logic
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PIDTextBox.Clear();
            IngTextBox.Clear();
            QtextBox.Clear();
            STextBox.Clear();
            LtextBox.Clear();
            ItextBox.Clear();
            InDatextBox.Clear();
            
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PIDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                IngTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                QtextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                STextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                LtextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                ItextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                InDatextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                
              



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Ingredients data: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this ingredient?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string selectedID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); // Assuming ID is the first column

                    using (OleDbCommand cmd = new OleDbCommand("DELETE FROM Ingredients WHERE ID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Ingredient deleted successfully!");
                        GetIngredients(); // Refresh the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting ingredient: " + ex.Message);
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoffeeForm CoffeeForm = new CoffeeForm();
            CoffeeForm.ShowDialog();
        }

        private void DashButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BDash BDash = new BDash();
            BDash.ShowDialog();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm UserForm = new UserForm();
            UserForm.ShowDialog();
        }

        private void InventButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryForm InventoryForm = new InventoryForm();
            InventoryForm.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryForm InventoryForm = new InventoryForm();
            InventoryForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalIngredientsForm TotalIngredientsForm = new TotalIngredientsForm();
            TotalIngredientsForm.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InventButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InventoryForm InventoryForm = new InventoryForm();
            InventoryForm.ShowDialog();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BOrders BOrders = new BOrders();
            BOrders.ShowDialog();
        }
    }
}
