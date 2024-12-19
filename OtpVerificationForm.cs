using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace LoginForm
{
    public partial class OtpVerificationForm : Form
    {
        private int attemptCounter = 0; // To track attempts
        private int maxAttempts = 3;
        private string validOtp;
        private string userEmail;

        public OtpVerificationForm(string otp, string email)
        {
            InitializeComponent();
            // Store the received OTP and email in the form for later use
            this.validOtp = otp;
            this.userEmail = email;
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            if (otpTextBox.Text == validOtp)
            {
                // OTP is correct, proceed to Password Reset Form
                ResetPasswordForm ResetPasswordForm = new ResetPasswordForm(userEmail);
                ResetPasswordForm.Show();
                this.Hide();
            }
            else
            {
                attemptCounter++;
                if (attemptCounter >= maxAttempts)
                {
                    warningLabel.Text = "Too many failed attempts. Please wait 1 minute before retrying.";
                    VerifyButton.Enabled = false;
                    Timer timer = new Timer();
                    timer.Interval = 60000; // 1 minute
                    timer.Tick += (s, args) =>
                    {
                        VerifyButton.Enabled = true;
                        attemptCounter = 0;
                        warningLabel.Text = "";
                        timer.Stop();
                    };
                    timer.Start();
                }
                else
                {
                    warningLabel.Text = $"Invalid OTP. Remaining attempts: {maxAttempts - attemptCounter}.";
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide Form2
            forgotPasswordForm forgotPasswordForm = new forgotPasswordForm(); // Create an instance of Form1
            forgotPasswordForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
