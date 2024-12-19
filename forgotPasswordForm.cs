using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    public partial class forgotPasswordForm : Form
    {
        public forgotPasswordForm()
        {
            InitializeComponent();
            SetRoundedEdges(cafe, 80); // Adjust 20 for different corner radius
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

        private void GenerateOtpButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;

            // Database connection (adjust connection string for your Access database)
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\clare\source\repos\LoginForm\LoginForm\bin\Debug\Account.accdb;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Email = @Email";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    // Generate OTP and send email
                    string otp = GenerateOTP();
                    SendEmail(email, otp);

                    // Open OTP Validation Form
                    OtpVerificationForm OtpVerificationForm = new OtpVerificationForm(otp, email); // Pass OTP and email
                    OtpVerificationForm.Show();
                    this.Hide();
                }
                else
                {
                    warningLabel.Text = "Email not registered.";
                }
            }
        }


        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendEmail(string to, string otp)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("bigbossgernie06@gmail.com");
                mail.To.Add(to);
                mail.Subject = "Your OTP";
                mail.Body = $"Your OTP is: {otp}";

                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("bigbossgernie06@gmail.com", "djhf wqkx vrbw rehm");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending OTP: " + ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide Form2
            loginForm loginForm = new loginForm(); // Create an instance of Form1
            loginForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
