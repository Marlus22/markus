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
    public partial class AddCoffeeForm : Form
    {
        private OleDbConnection conn;
        private string imagePath; // To store the path of the uploaded image

        public AddCoffeeForm()
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

        void GetCoffeeAddTable()
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM CoffeeAddTable", conn))
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void InventButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoffeeForm CoffeeForm = new CoffeeForm();
            CoffeeForm.ShowDialog();
        }

        private void POSButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            POSForm POSForm = new POSForm();
            POSForm.ShowDialog();
        }

        private void ACButton_Click(object sender, EventArgs e)
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

        private void AddCoffeeForm_Load(object sender, EventArgs e)
        {
            GetCoffeeAddTable();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PIDTextBox.Text) || string.IsNullOrWhiteSpace(CofTextBox.Text) ||
                  string.IsNullOrWhiteSpace(CBTextBox.Text) || string.IsNullOrWhiteSpace(MtextBox.Text) ||
                  string.IsNullOrWhiteSpace(StextBox.Text) || string.IsNullOrWhiteSpace(PtextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            byte[] imageBytes = null;
            if (!string.IsNullOrEmpty(imagePath))
            {
                imageBytes = File.ReadAllBytes(imagePath);
            }

            using (OleDbCommand cmd = new OleDbCommand("INSERT INTO CoffeeAddTable (ID, Coffee, CoffeeBeans, Milk, Sugar, Price, CoffeeImage) VALUES (@id, @c, @cb, @m, @s, @p, @img)", conn))
            {
                cmd.Parameters.AddWithValue("@id", PIDTextBox.Text);
                cmd.Parameters.AddWithValue("@c", CofTextBox.Text);
                cmd.Parameters.AddWithValue("@cb", CBTextBox.Text);
                cmd.Parameters.AddWithValue("@m", MtextBox.Text);
                cmd.Parameters.AddWithValue("@s", StextBox.Text);
                cmd.Parameters.AddWithValue("@p", PtextBox.Text);
                cmd.Parameters.AddWithValue("@img", imageBytes);

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

                GetCoffeeAddTable();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PIDTextBox.Clear();
            CofTextBox.Clear();
            CBTextBox.Clear();
            MtextBox.Clear();
            StextBox.Clear();
            PtextBox.Clear();
            Coffeeimg.Image = null; // Clear the image
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName; // Store the image path
                    Coffeeimg.Image = new Bitmap(imagePath); // Display the image in the PictureBox
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            PIDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CofTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CBTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            MtextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            StextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            PtextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string imagePath = GetCellValue(dataGridView1.CurrentRow.Cells[6]);
            LoadImage(imagePath);
        }


        private string GetCellValue(DataGridViewCell cell)
        {
            return cell.Value != null ? cell.Value.ToString() : string.Empty;
        }

        private void LoadImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    Coffeeimg.Image = Image.FromFile(imagePath);
                }
                else
                {
                    Coffeeimg.Image = null; // Clear image if path is invalid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                Coffeeimg.Image = null; // Clear image on error
            }
        }
    }
}
