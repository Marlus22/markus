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
    public partial class POSForm : Form
    {
        private OleDbConnection conn;
        private DataTable orderTable; // Table to hold orders


        public POSForm()
        {
            InitializeComponent();
            SetRoundedEdges(cafe, 80); // Adjust 20 for different corner radius
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\clare\source\repos\LoginForm\LoginForm\bin\Debug\Account.accdb");
            LoadData(); // Call to load data when the form is initialized
            InitializeOrderTable(); // Initialize the order table
            PaymentTextBox.TextChanged += PaymentTextBox_TextChanged; // Event for payment textbox
        }


        private void InitializeOrderTable()
        {
            orderTable = new DataTable();
            orderTable.Columns.Add("Coffee", typeof(string));
            orderTable.Columns.Add("Price", typeof(decimal));
            orderTable.Columns.Add("Quantity", typeof(int));
            orderTable.Columns.Add("Total", typeof(decimal), "Price * Quantity"); // Adding Total column
            dataGridView3.DataSource = orderTable; // Bind the order table to dataGridView3
        }
        private void UpdateTotal()
        {
            decimal grandTotal = orderTable.AsEnumerable().Sum(row => row.Field<decimal>("Total"));
            lblTotal.Text = $"Total: {grandTotal:C}"; // Assuming lblTotal is a Label to display the total
            PrintButton.Enabled = false; // Disable print button initially
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

        private void LoadData()
        {
            // Load data from CoffeeAddTable into dataGridView2
            using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Coffee, Price FROM CoffeeAddTable", conn))
            {
                try
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
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

            // Load data from receipts table into dataGridView1
            using (OleDbDataAdapter adapter2 = new OleDbDataAdapter("SELECT * FROM Receipts", conn))
            {
                try
                {
                    conn.Open();
                    DataTable dt2 = new DataTable();
                    adapter2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
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



        private void DashButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm DashboardForm = new DashboardForm();
            DashboardForm.ShowDialog();
        }

        private void UserButton_Click_1(object sender, EventArgs e)
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

        private void HistoryButton_Click_1(object sender, EventArgs e)
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

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                string coffeeName = dataGridView2.CurrentRow.Cells["Coffee"].Value.ToString();
                decimal price = Convert.ToDecimal(dataGridView2.CurrentRow.Cells["Price"].Value);

                // Check stock before adding to the order
                if (IsStockSufficient(coffeeName))
                {
                    AddOrUpdateOrder(coffeeName, price);
                }
                else
                {
                    MessageBox.Show($"Insufficient stock for {coffeeName}. Cannot place order.",
                                    "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a coffee to place an order.");
            }
        }

        private bool IsStockSufficient(string coffeeName)
        {
            bool isSufficient = false;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(conn.ConnectionString))
                {
                    connection.Open();

                    // Query to fetch the available quantity of the selected coffee
                    string query = "SELECT Quantity FROM CoffeeInTable WHERE Coffee = @coffeeName";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@coffeeName", coffeeName);
                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int availableQuantity))
                        {
                            // Check against current order quantity
                            int orderedQuantity = 1; // Default to adding 1 quantity at a time
                            DataRow[] existingRows = orderTable.Select($"Coffee = '{coffeeName}'");
                            if (existingRows.Length > 0)
                            {
                                orderedQuantity += (int)existingRows[0]["Quantity"];
                            }

                            isSufficient = availableQuantity >= orderedQuantity;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSufficient;
        }

        private void AddOrUpdateOrder(string coffeeName, decimal price)
        {
            DataRow[] existingRows = orderTable.Select($"Coffee = '{coffeeName}'");
            if (existingRows.Length > 0)
            {
                // If the coffee already exists, increment the quantity
                existingRows[0]["Quantity"] = (int)existingRows[0]["Quantity"] + 1;
            }
            else
            {
                // If it's a new coffee, add it to the order table
                DataRow newRow = orderTable.NewRow();
                newRow["Coffee"] = coffeeName;
                newRow["Price"] = price;
                newRow["Quantity"] = 1;
                orderTable.Rows.Add(newRow);
            }
            UpdateTotal(); // Update the total after adding/updating an order
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Clear the DataGridView
            orderTable.Clear();
            lblTotal.Text = "Total: ₱0.00"; // Reset total display
        }

        private void DeductButton_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                DataRow selectedRow = ((DataRowView)dataGridView3.CurrentRow.DataBoundItem).Row;
                int currentQuantity = (int)selectedRow["Quantity"];

                if (currentQuantity > 1)
                {
                    // Decrease the quantity by 1
                    selectedRow["Quantity"] = currentQuantity - 1;
                }
                else
                {
                    // Remove the item if quantity is 1
                    orderTable.Rows.Remove(selectedRow);
                }
                UpdateTotal(); // Update the total after deducting an order
            }
        }

        private void PaymentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(PaymentTextBox.Text, out decimal paymentAmount))
            {
                decimal totalAmount = orderTable.AsEnumerable().Sum(row => row.Field<decimal>("Total"));
                PrintButton.Enabled = paymentAmount >= totalAmount; // Enable button if payment is sufficient
            }
            else
            {
                PrintButton.Enabled = false; // Disable if input is not a valid decimal
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Logic to print the receipt
            MessageBox.Show("Receipt printed successfully!"); // Placeholder for actual print logic

            // Insert data into Access database
            InsertDataIntoDatabase(); // Your existing method to handle orders and ingredients

            // Insert the order into the receipts table
            InsertOrderIntoReceipts();

            // Refresh the receipts table data
            LoadReceiptsData();

            // Resetting the form after printing
            DisplayReceipt();
            ResetForm();
            LoadData(); // Reload Coffee and Ingredients data if needed
        }

        private void DisplayReceipt()
        {
            // Create a new form for the receipt
            Form receiptForm = new Form();
            receiptForm.Text = "Receipt";
            receiptForm.Size = new Size(300, 400);
            receiptForm.StartPosition = FormStartPosition.CenterScreen;

            // Create a label to display the receipt details
            Label receiptLabel = new Label();
            receiptLabel.AutoSize = true;
            receiptLabel.Location = new Point(10, 10);
            receiptLabel.Font = new Font("Arial", 12);
            receiptLabel.Text = GenerateReceiptText();

            // Add the label to the receipt form
            receiptForm.Controls.Add(receiptLabel);
            receiptForm.ShowDialog(); // Show the receipt form as a dialog
        }

        private string GenerateReceiptText()
        {
            StringBuilder receiptText = new StringBuilder();
            receiptText.AppendLine("Receipt");
            receiptText.AppendLine($"Cafe: Cafe Carolina");
            receiptText.AppendLine($"Date: {DateTime.Now}");

            // Fetching the system user's name from the Access database
            string userFullName = GetUserFullNameFromDatabase();
            receiptText.AppendLine($"User: {userFullName}"); // Displaying the system user's name
            receiptText.AppendLine("Items Purchased:");

            foreach (DataRow row in orderTable.Rows)
            {
                receiptText.AppendLine($"{row["Coffee"]} - Qty: {row["Quantity"]} - Total: {row["Total"]:C}");
            }

            decimal grandTotal = orderTable.AsEnumerable().Sum(r => r.Field<decimal>("Total"));
            receiptText.AppendLine($"Grand Total: {grandTotal:C}");

            // Assuming PaymentTextBox contains the payment amount as a string
            decimal paymentAmount = decimal.Parse(PaymentTextBox.Text);
            receiptText.AppendLine($"Payment: {paymentAmount:C}");

            // Calculate change
            decimal change = paymentAmount - grandTotal;
            receiptText.AppendLine($"Change: {change:C}");


            return receiptText.ToString();
        }


     

        private string GetUserFullNameFromDatabase()
        {
            string userFullName = string.Empty;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(conn.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT FullName FROM Users WHERE ID = @id"; // Adjust the query as needed

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", userFullName); // Assuming CurrentUserId holds the ID of the logged-in user
                        userFullName = command.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userFullName;
        }


        private void InsertDataIntoDatabase()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(conn.ConnectionString))
                {
                    connection.Open();

                    foreach (DataRow row in orderTable.Rows)
                    {
                        string coffeeName = row["Coffee"].ToString();
                        int orderedQuantity = Convert.ToInt32(row["Quantity"]);

                        // Deduct Coffee Quantity in CoffeeInTable
                        string updateCoffeeQuery = "UPDATE CoffeeInTable SET Quantity = Quantity - @orderedQty WHERE Coffee = @coffeeName";
                        using (OleDbCommand updateCoffeeCommand = new OleDbCommand(updateCoffeeQuery, connection))
                        {
                            updateCoffeeCommand.Parameters.AddWithValue("@orderedQty", orderedQuantity);
                            updateCoffeeCommand.Parameters.AddWithValue("@coffeeName", coffeeName);
                            updateCoffeeCommand.ExecuteNonQuery();
                        }

                        // Query to get the required ingredients for the coffee
                        string selectQuery = "SELECT CoffeeBeans, Milk, Sugar FROM CoffeeAddTable WHERE Coffee = @coffeeName";

                        using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection))
                        {
                            selectCommand.Parameters.AddWithValue("@coffeeName", coffeeName);

                            using (OleDbDataReader reader = selectCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Deduct Coffee Beans
                                    decimal coffeeBeansUsed = Convert.ToDecimal(reader["CoffeeBeans"].ToString().Split(' ')[0]) * orderedQuantity / 1000m; // Convert grams to kg
                                    UpdateIngredient(connection, "Coffee Beans", coffeeBeansUsed);

                                    // Deduct Milk
                                    decimal milkUsed = Convert.ToDecimal(reader["Milk"].ToString().Split(' ')[0]) * orderedQuantity / 1000m; // Convert ml to L
                                    UpdateIngredient(connection, "Milk", milkUsed);

                                    // Deduct Sugar
                                    decimal sugarUsed = Convert.ToDecimal(reader["Sugar"].ToString().Split(' ')[0]) * orderedQuantity / 1000m; // Convert grams to kg
                                    UpdateIngredient(connection, "Sugar", sugarUsed);
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Inventory updated successfully!");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database error while updating inventory: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



       

        private void UpdateIngredient(OleDbConnection connection, string ingredientName, decimal quantityUsed)
        {
            // Deduct the specific ingredient quantity
            string updateQuery = "UPDATE Ingredients SET Quantity = Quantity - @usedQty WHERE IngredientsName = @name";

            using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@usedQty", quantityUsed);
                updateCommand.Parameters.AddWithValue("@name", ingredientName);
                updateCommand.ExecuteNonQuery();
            }
        }

        private void InsertOrderIntoReceipts()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(conn.ConnectionString))
                {
                    connection.Open();

                    foreach (DataRow row in orderTable.Rows)
                    {
                        string insertQuery = "INSERT INTO Receipts (Coffee, Price, Quantity, Total, ReceiptDate) " +
                                             "VALUES (@coffee, @price, @quantity, @total, @receiptDate)";

                        using (OleDbCommand cmd = new OleDbCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@coffee", row["Coffee"].ToString());
                            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(row["Price"]));
                            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(row["Quantity"]));
                            cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(row["Total"]));
                            cmd.Parameters.AddWithValue("@receiptDate", DateTime.Now);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database error while inserting receipts: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void LoadReceiptsData()
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Receipts", conn))
            {
                try
                {
                    conn.Open();
                    DataTable receiptsTable = new DataTable();
                    adapter.Fill(receiptsTable);
                    dataGridView1.DataSource = receiptsTable; // Bind the data to dataGridView1
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading receipts: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void ResetForm()
        {
            orderTable.Clear();
            lblTotal.Text = "Total: ₱0.00";
            PaymentTextBox.Clear();
            PrintButton.Enabled = false;
        }
       
    }
}
       
    
    
