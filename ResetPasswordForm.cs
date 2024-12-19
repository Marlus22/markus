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
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace LoginForm
{
    public partial class ResetPasswordForm : Form
    {
        private string userEmail;

        public ResetPasswordForm(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            if (newPassword != confirmPassword)
            {
                warningLabel.Text = "Passwords do not match.";
                return;
            }

            // Update the password in the database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\clare\\source\\repos\\LoginForm\\LoginForm\\bin\\Debug\\Account.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "UPDATE Users SET [Password] = @password WHERE Email = @email";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@password", newPassword);
                command.Parameters.AddWithValue("@email", userEmail);

                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    warningLabel.Text = "Password successfully updated!";
                    loginForm loginForm = new loginForm();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    warningLabel.Text = "Error updating password. Try again.";
                }
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newPasswordTextBox.PasswordChar = ShowPasswordCheckBox.Checked ? '\0' : '*';
        }

        private void ShowPasswordCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            confirmPasswordTextBox.PasswordChar = ShowPasswordCheckBox1.Checked ? '\0' : '*';
        }
    }
}
