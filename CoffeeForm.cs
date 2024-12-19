using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    public partial class CoffeeForm : Form
    {
        private OleDbConnection conn;

        public CoffeeForm()
        {
            InitializeComponent();
            SetRoundedEdges(cafe, 80); // Adjust 20 for different corner radius
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\clare\source\repos\LoginForm\LoginForm\bin\Debug\Account.accdb");

        }

        void GetCoffeeInTable()
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM CoffeeInTable", conn))
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
                    MessageBox.Show("Error retrieving Coffee: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashButton_Click(object sender, EventArgs e)
        {
            DashboardForm DashboardForm = new DashboardForm();
            DashboardForm.ShowDialog();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            UserForm UserForm = new UserForm();
            UserForm.ShowDialog();
        }

        private void InventButton_Click(object sender, EventArgs e)
        {
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
            AddCoffeeForm AddCoffeeForm = new AddCoffeeForm();
            AddCoffeeForm.ShowDialog();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HistoryForm HistoryForm = new HistoryForm();
            HistoryForm.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventoryForm InventoryForm = new InventoryForm();
            InventoryForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalIngredientsForm TotalIngredientsForm = new TotalIngredientsForm();
            TotalIngredientsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoffeeForm CoffeeForm = new CoffeeForm();
            CoffeeForm.ShowDialog();
        }

        private void CoffeeForm_Load(object sender, EventArgs e)
        {
            GetCoffeeInTable();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(PIDTextBox.Text) || string.IsNullOrWhiteSpace(CofTextBox.Text) || string.IsNullOrWhiteSpace(QtextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            using (OleDbCommand cmd = new OleDbCommand("INSERT INTO CoffeeInTable (ID, Coffee, Quantity) VALUES (@id, @c, @q)", conn))
            {
                cmd.Parameters.AddWithValue("@id", PIDTextBox.Text);
                cmd.Parameters.AddWithValue("@c", CofTextBox.Text);
                cmd.Parameters.AddWithValue("@q", QtextBox.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Coffee Inserted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting Coffee: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                GetCoffeeInTable();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PIDTextBox.Clear();
            CofTextBox.Clear();
            QtextBox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PIDTextBox.Text))
            {
                MessageBox.Show("Please enter an ID to delete.");
                return;
            }

            using (OleDbCommand cmd = new OleDbCommand("DELETE FROM CoffeeInTable WHERE ID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", PIDTextBox.Text);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Coffee Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("No Coffee found with that ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting Coffee: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                GetCoffeeInTable();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            PIDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CofTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            QtextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
