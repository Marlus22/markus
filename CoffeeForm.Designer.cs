
namespace LoginForm
{
    partial class CoffeeForm
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
            this.Close = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.QtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CofTextBox = new System.Windows.Forms.TextBox();
            this.PIDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(1372, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(27, 25);
            this.Close.TabIndex = 48;
            this.Close.Text = "X";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.ClearButton);
            this.panel3.Controls.Add(this.DeleteButton);
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Controls.Add(this.QtextBox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.CofTextBox);
            this.panel3.Controls.Add(this.PIDTextBox);
            this.panel3.Location = new System.Drawing.Point(316, 567);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1083, 229);
            this.panel3.TabIndex = 47;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.ClearButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(574, 168);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(83, 43);
            this.ClearButton.TabIndex = 43;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.DeleteButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(466, 168);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(83, 43);
            this.DeleteButton.TabIndex = 42;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.AddButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(356, 168);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(83, 43);
            this.AddButton.TabIndex = 41;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // QtextBox
            // 
            this.QtextBox.Location = new System.Drawing.Point(433, 125);
            this.QtextBox.Multiline = true;
            this.QtextBox.Name = "QtextBox";
            this.QtextBox.Size = new System.Drawing.Size(224, 27);
            this.QtextBox.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Coffee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Product ID";
            // 
            // CofTextBox
            // 
            this.CofTextBox.Location = new System.Drawing.Point(433, 69);
            this.CofTextBox.Multiline = true;
            this.CofTextBox.Name = "CofTextBox";
            this.CofTextBox.Size = new System.Drawing.Size(224, 27);
            this.CofTextBox.TabIndex = 24;
            // 
            // PIDTextBox
            // 
            this.PIDTextBox.Location = new System.Drawing.Point(433, 16);
            this.PIDTextBox.Multiline = true;
            this.PIDTextBox.Name = "PIDTextBox";
            this.PIDTextBox.Size = new System.Drawing.Size(224, 27);
            this.PIDTextBox.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(316, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 493);
            this.panel2.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 409);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Inventory of Coffee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.panel1.TabIndex = 45;
            // 
            // Rolelabel
            // 
            this.Rolelabel.AutoSize = true;
            this.Rolelabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolelabel.ForeColor = System.Drawing.Color.White;
            this.Rolelabel.Location = new System.Drawing.Point(195, 212);
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
            this.Fnamelabel.Location = new System.Drawing.Point(5, 288);
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
            this.Unamelabel.Location = new System.Drawing.Point(5, 249);
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
            this.UIDlabel.Location = new System.Drawing.Point(5, 212);
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
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
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
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
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
            this.DashButton.Click += new System.EventHandler(this.DashButton_Click);
            // 
            // CoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 808);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoffeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeForm";
            this.Load += new System.EventHandler(this.CoffeeForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox QtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CofTextBox;
        private System.Windows.Forms.TextBox PIDTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cafe;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button APButton;
        private System.Windows.Forms.Button POSButton;
        private System.Windows.Forms.Button InventButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button DashButton;
        private System.Windows.Forms.Label Rolelabel;
        private System.Windows.Forms.Label Fnamelabel;
        private System.Windows.Forms.Label Unamelabel;
        private System.Windows.Forms.Label UIDlabel;
    }
}