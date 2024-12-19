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
    public partial class InAndOutForm : Form
    {
        private DataTable dataTable;

        public InAndOutForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadData();
        }

        private void LoadData()
        {
            // Example data, replace with actual data retrieval logic
            dataTable.Rows.Add("1", "bigbossgernie06@gmail.com", DateTime.Now.AddHours(-1), DateTime.Now);
            dataTable.Rows.Add("2", "Sammy456@gmail.com", DateTime.Now.AddHours(-2), DateTime.Now.AddHours(-1));
        }

        private void InitializeDataGridView()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("UserID", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("TimeIn", typeof(DateTime));
            dataTable.Columns.Add("TimeOut", typeof(DateTime));

            dataGridView1.DataSource = dataTable;
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
            
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryForm HistoryForm = new HistoryForm();
            HistoryForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InAndOutForm InAndOutForm = new InAndOutForm();
            InAndOutForm.ShowDialog();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesForm SalesForm = new SalesForm();
            SalesForm.ShowDialog();
        }
    }
}
