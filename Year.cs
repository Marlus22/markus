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
    public partial class Year : Form
    {
        private OleDbConnection conn;

        public Year()
        {
            InitializeComponent();
            SetRoundedEdges(cafe, 80); // Adjust 20 for different corner radius
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\clare\source\repos\LoginForm\LoginForm\bin\Debug\Account.accdb");
            LoadData(); // Call to load data when the form is initialized


        }

        private void LoadData()
        {
            // Load data from receipts table into dataGridView1
            using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Receipts", conn))
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
                    MessageBox.Show("Error retrieving Receipts: " + ex.Message);
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


        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesForm SalesForm = new SalesForm();
            SalesForm.ShowDialog();
        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Month Month = new Month();
            Month.ShowDialog();
        }

        private void YearButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Year Year = new Year();
            Year.ShowDialog();
        }
    }
}
