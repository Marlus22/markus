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


namespace LoginForm
{
    public partial class DashboardForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\clare\source\repos\LoginForm\LoginForm\bin\Debug\Account.accdb";
        private Timer timer;

        public DashboardForm()
        {
            InitializeComponent();
            InitializeDateTimeLabel();
            LoadUserCount();
            LoadCustomerCount();
            DisplayTotal();
        }

        private void InitializeDateTimeLabel()
        {
            // Create a new Timer
            timer = new Timer();
            timer.Interval = 1000; // Set the timer interval to 1 second (1000 milliseconds)
            timer.Tick += Timer_Tick; // Subscribe to the Tick event
            timer.Start(); // Start the timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            DTlabel.Text = DateTime.Now.ToString("F"); // "F" for full date/time pattern
        }

        private void UpdateDateTimeLabel(Label DTlabel)
        {
            // Update the label text with the current date and time
            if (DTlabel.InvokeRequired)
            {
                DTlabel.Invoke(new Action(() => DTlabel.Text = DateTime.Now.ToString("F")));
            }
            else
            {
                DTlabel.Text = DateTime.Now.ToString("F");
            }
        }

        private void LoadUserCount()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users"; // Assuming 'Users' is your table name
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        int userCount = (int)command.ExecuteScalar();
                        UserNolabel.Text = $"{userCount}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LoadCustomerCount()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Receipts"; // Assuming 'Receipts' is your table name
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        int userCount = (int)command.ExecuteScalar();
                        CusNolabel.Text = $"{userCount}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void DisplayTotal()
        {
            decimal totalAmount = GetTotalFromReceipts();
            ToIlabel.Text = $" {totalAmount:C}";
        }



        private decimal GetTotalFromReceipts()
        {
            decimal total = 0;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT SUM(Total) AS TotalSum FROM Receipts";
                OleDbCommand command = new OleDbCommand(query, connection);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return total;
        }


        private void ToIlabel_Click(object sender, EventArgs e)
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

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
