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
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    public partial class loginForm : Form
    {
        private OleDbConnection conn = new OleDbConnection();

        public loginForm()
        {
            InitializeComponent();
            SetRoundedEdges(cafe, 80); // Adjust 20 for different corner radius
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\clare\source\repos\LoginForm\LoginForm\bin\Debug\Account.accdb;Persist Security Info=False;";
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


        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                // Improved query with parameterized role selection
                cmd.CommandText = "SELECT Role FROM Users WHERE Email = @email AND Password = @password";
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader.GetString(0); // Get the retrieved role

                    switch (role)
                    {
                        case "Admin":
                            MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            DashboardForm DashboardForm = new DashboardForm();
                            DashboardForm.ShowDialog();
                            break;
                        case "Cashier":
                            MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            CDash CDash = new CDash();
                            CDash.ShowDialog();
                            break;
                        case "Barista":
                            MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            BDash BDash = new BDash();
                            BDash.ShowDialog();
                            break;
                        default:
                            MessageBox.Show("Invalid Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Email and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void ForgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to the Forgot Password form
            forgotPasswordForm forgotPasswordForm = new forgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide(); // Hide the current login form if needed
            conn.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = CheckPass.Checked ? '\0' : '*';
        }
    }
}
