
namespace LoginForm
{
    partial class POSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.History = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Close = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentTextBox = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ForButtons = new System.Windows.Forms.Panel();
            this.DeductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rolelabel = new System.Windows.Forms.Label();
            this.Fnamelabel = new System.Windows.Forms.Label();
            this.Unamelabel = new System.Windows.Forms.Label();
            this.UIDlabel = new System.Windows.Forms.Label();
            this.cafe = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.APButton = new System.Windows.Forms.Button();
            this.POSButton = new System.Windows.Forms.Button();
            this.InventButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.DashButton = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.Panel();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.ForButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).BeginInit();
            this.Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.History.Controls.Add(this.dataGridView1);
            this.History.Location = new System.Drawing.Point(322, 658);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(1077, 138);
            this.History.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 107);
            this.dataGridView1.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(1372, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(27, 25);
            this.Close.TabIndex = 23;
            this.Close.Text = "X";
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.List.Controls.Add(this.label1);
            this.List.Controls.Add(this.PaymentTextBox);
            this.List.Controls.Add(this.lblTotal);
            this.List.Controls.Add(this.dataGridView3);
            this.List.Controls.Add(this.ForButtons);
            this.List.Location = new System.Drawing.Point(807, 51);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(586, 578);
            this.List.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Payment";
            // 
            // PaymentTextBox
            // 
            this.PaymentTextBox.Location = new System.Drawing.Point(124, 429);
            this.PaymentTextBox.Multiline = true;
            this.PaymentTextBox.Name = "PaymentTextBox";
            this.PaymentTextBox.Size = new System.Drawing.Size(181, 30);
            this.PaymentTextBox.TabIndex = 29;
            this.PaymentTextBox.TextChanged += new System.EventHandler(this.PaymentTextBox_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(48, 386);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 17);
            this.lblTotal.TabIndex = 28;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(20, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(550, 448);
            this.dataGridView3.TabIndex = 27;
            // 
            // ForButtons
            // 
            this.ForButtons.BackColor = System.Drawing.SystemColors.Control;
            this.ForButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForButtons.Controls.Add(this.DeductButton);
            this.ForButtons.Controls.Add(this.CancelButton);
            this.ForButtons.Controls.Add(this.PrintButton);
            this.ForButtons.Location = new System.Drawing.Point(20, 465);
            this.ForButtons.Name = "ForButtons";
            this.ForButtons.Size = new System.Drawing.Size(550, 95);
            this.ForButtons.TabIndex = 1;
            // 
            // DeductButton
            // 
            this.DeductButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeductButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeductButton.Location = new System.Drawing.Point(222, 27);
            this.DeductButton.Name = "DeductButton";
            this.DeductButton.Size = new System.Drawing.Size(122, 45);
            this.DeductButton.TabIndex = 2;
            this.DeductButton.Text = "Deduct";
            this.DeductButton.UseVisualStyleBackColor = false;
            this.DeductButton.Click += new System.EventHandler(this.DeductButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.LightCoral;
            this.CancelButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(57, 27);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(122, 45);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel Order";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.PaleGreen;
            this.PrintButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(382, 27);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(122, 45);
            this.PrintButton.TabIndex = 0;
            this.PrintButton.Text = "Print Receipt";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.Rolelabel);
            this.panel1.Controls.Add(this.Fnamelabel);
            this.panel1.Controls.Add(this.Unamelabel);
            this.panel1.Controls.Add(this.UIDlabel);
            this.panel1.Controls.Add(this.cafe);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.HistoryButton);
            this.panel1.Controls.Add(this.APButton);
            this.panel1.Controls.Add(this.POSButton);
            this.panel1.Controls.Add(this.InventButton);
            this.panel1.Controls.Add(this.UserButton);
            this.panel1.Controls.Add(this.DashButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 808);
            this.panel1.TabIndex = 20;
            // 
            // Rolelabel
            // 
            this.Rolelabel.AutoSize = true;
            this.Rolelabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolelabel.ForeColor = System.Drawing.Color.White;
            this.Rolelabel.Location = new System.Drawing.Point(191, 211);
            this.Rolelabel.Name = "Rolelabel";
            this.Rolelabel.Size = new System.Drawing.Size(103, 17);
            this.Rolelabel.TabIndex = 15;
            this.Rolelabel.Text = "Role : Admin";
            // 
            // Fnamelabel
            // 
            this.Fnamelabel.AutoSize = true;
            this.Fnamelabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fnamelabel.ForeColor = System.Drawing.Color.White;
            this.Fnamelabel.Location = new System.Drawing.Point(1, 287);
            this.Fnamelabel.Name = "Fnamelabel";
            this.Fnamelabel.Size = new System.Drawing.Size(279, 17);
            this.Fnamelabel.TabIndex = 14;
            this.Fnamelabel.Text = "Full Name : Kyle Gernie Del Rosario";
            // 
            // Unamelabel
            // 
            this.Unamelabel.AutoSize = true;
            this.Unamelabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unamelabel.ForeColor = System.Drawing.Color.White;
            this.Unamelabel.Location = new System.Drawing.Point(1, 248);
            this.Unamelabel.Name = "Unamelabel";
            this.Unamelabel.Size = new System.Drawing.Size(157, 17);
            this.Unamelabel.TabIndex = 13;
            this.Unamelabel.Text = "Username : Kyle_06";
            // 
            // UIDlabel
            // 
            this.UIDlabel.AutoSize = true;
            this.UIDlabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIDlabel.ForeColor = System.Drawing.Color.White;
            this.UIDlabel.Location = new System.Drawing.Point(1, 211);
            this.UIDlabel.Name = "UIDlabel";
            this.UIDlabel.Size = new System.Drawing.Size(99, 17);
            this.UIDlabel.TabIndex = 12;
            this.UIDlabel.Text = "User ID : 01";
            // 
            // cafe
            // 
            this.cafe.Image = global::LoginForm.Properties.Resources._460130162_122095454768537883_8055968607088583724_n;
            this.cafe.Location = new System.Drawing.Point(64, 31);
            this.cafe.Name = "cafe";
            this.cafe.Size = new System.Drawing.Size(167, 154);
            this.cafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cafe.TabIndex = 11;
            this.cafe.TabStop = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(105)))), ((int)(((byte)(6)))));
            this.LogoutButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(106, 760);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(99, 36);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(105)))), ((int)(((byte)(6)))));
            this.HistoryButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.Color.White;
            this.HistoryButton.Location = new System.Drawing.Point(0, 658);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(310, 36);
            this.HistoryButton.TabIndex = 8;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click_1);
            // 
            // APButton
            // 
            this.APButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(105)))), ((int)(((byte)(6)))));
            this.APButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APButton.ForeColor = System.Drawing.Color.White;
            this.APButton.Location = new System.Drawing.Point(0, 593);
            this.APButton.Name = "APButton";
            this.APButton.Size = new System.Drawing.Size(310, 36);
            this.APButton.TabIndex = 7;
            this.APButton.Text = "Add Coffee";
            this.APButton.UseVisualStyleBackColor = false;
            this.APButton.Click += new System.EventHandler(this.APButton_Click);
            // 
            // POSButton
            // 
            this.POSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(105)))), ((int)(((byte)(6)))));
            this.POSButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSButton.ForeColor = System.Drawing.Color.White;
            this.POSButton.Location = new System.Drawing.Point(0, 525);
            this.POSButton.Name = "POSButton";
            this.POSButton.Size = new System.Drawing.Size(310, 36);
            this.POSButton.TabIndex = 6;
            this.POSButton.Text = "POS";
            this.POSButton.UseVisualStyleBackColor = false;
            this.POSButton.Click += new System.EventHandler(this.POSButton_Click);
            // 
            // InventButton
            // 
            this.InventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(105)))), ((int)(((byte)(6)))));
            this.InventButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventButton.ForeColor = System.Drawing.Color.White;
            this.InventButton.Location = new System.Drawing.Point(0, 451);
            this.InventButton.Name = "InventButton";
            this.InventButton.Size = new System.Drawing.Size(310, 36);
            this.InventButton.TabIndex = 5;
            this.InventButton.Text = "Inventory";
            this.InventButton.UseVisualStyleBackColor = false;
            this.InventButton.Click += new System.EventHandler(this.InventButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(105)))), ((int)(((byte)(6)))));
            this.UserButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserButton.ForeColor = System.Drawing.Color.White;
            this.UserButton.Location = new System.Drawing.Point(0, 386);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(310, 36);
            this.UserButton.TabIndex = 4;
            this.UserButton.Text = "Users";
            this.UserButton.UseVisualStyleBackColor = false;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click_1);
            // 
            // DashButton
            // 
            this.DashButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(105)))), ((int)(((byte)(6)))));
            this.DashButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashButton.ForeColor = System.Drawing.Color.White;
            this.DashButton.Location = new System.Drawing.Point(0, 320);
            this.DashButton.Name = "DashButton";
            this.DashButton.Size = new System.Drawing.Size(310, 36);
            this.DashButton.TabIndex = 1;
            this.DashButton.Text = "Dashboard";
            this.DashButton.UseVisualStyleBackColor = false;
            this.DashButton.Click += new System.EventHandler(this.DashButton_Click_1);
            // 
            // Items
            // 
            this.Items.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Items.Controls.Add(this.PlaceOrderButton);
            this.Items.Controls.Add(this.label2);
            this.Items.Controls.Add(this.dataGridView2);
            this.Items.Location = new System.Drawing.Point(332, 51);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(457, 578);
            this.Items.TabIndex = 22;
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.BackColor = System.Drawing.Color.PaleGreen;
            this.PlaceOrderButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderButton.Location = new System.Drawing.Point(159, 493);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(122, 45);
            this.PlaceOrderButton.TabIndex = 2;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = false;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 39);
            this.label2.TabIndex = 26;
            this.label2.Text = "Menu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(427, 499);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 808);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.List);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSForm";
            this.History.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.List.ResumeLayout(false);
            this.List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ForButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).EndInit();
            this.Items.ResumeLayout(false);
            this.Items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel History;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Panel List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cafe;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button APButton;
        private System.Windows.Forms.Button POSButton;
        private System.Windows.Forms.Button InventButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button DashButton;
        private System.Windows.Forms.Panel Items;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel ForButtons;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Button DeductButton;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PaymentTextBox;
        private System.Windows.Forms.Label Rolelabel;
        private System.Windows.Forms.Label Fnamelabel;
        private System.Windows.Forms.Label Unamelabel;
        private System.Windows.Forms.Label UIDlabel;
    }
}