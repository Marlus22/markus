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

namespace LoginForm
{
    public partial class TotalIngredientsForm : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\clare\\source\repos\\LoginForm\\LoginForm\\bin\\Debug\\Account.accdb;";

        public TotalIngredientsForm()
        {
            InitializeComponent();
            LoadTotalIngredients();
        }

        private void LoadTotalIngredients()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Ingredients, SUM(Quantity) AS TotalQuantity, SUM(Price) AS TotalPrice " +
                               "FROM Ingredients " +
                               "GROUP BY Ingredients";

                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable IngredientsTotal = new DataTable();
                adapter.Fill(IngredientsTotal);

                // Display the results in a DataGridView
                dataGridView1.DataSource = IngredientsTotal;

                // Insert totals into IngredientsTotal table
                InsertTotalsIntoIngredientsTotal(IngredientsTotal, connection);
            }
        }

        private void InsertTotalsIntoIngredientsTotal(DataTable IngredientsTotal, OleDbConnection connection)
        {
            foreach (DataRow row in IngredientsTotal.Rows)
            {
                string insertQuery = "INSERT INTO IngredientsTotal (Ingredients, TotalQuantity, TotalPrice) VALUES (@Ingredients, @TotalQuantity, @TotalPrice)";
                using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Ingredients", row["Ingredients"]);
                    insertCommand.Parameters.AddWithValue("@TotalQuantity", row["TotalQuantity"]);
                    insertCommand.Parameters.AddWithValue("@TotalPrice", row["TotalPrice"]);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        private void UpdateIngredientsTotal()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM IngredientsTotal"; // Clear existing totals
                new OleDbCommand(deleteQuery, connection).ExecuteNonQuery();

                string insertQuery = "INSERT INTO IngredientsTotal (Ingredients, TotalQuantity, TotalPrice) " +
                                     "SELECT Ingredients, SUM(Quantity) AS TotalQuantity, SUM(Price) AS TotalPrice " +
                                     "FROM Ingredients " +
                                     "GROUP BY Ingredients";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);
                insertCommand.ExecuteNonQuery();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoffeeForm CoffeeForm = new CoffeeForm();
            CoffeeForm.ShowDialog();
        }
    }
}
