
namespace LoginForm
{
    partial class BOrders
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cafe = new System.Windows.Forms.PictureBox();
            this.Rolelabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.DashButton = new System.Windows.Forms.Button();
            this.Fnamelabel = new System.Windows.Forms.Label();
            this.Unamelabel = new System.Windows.Forms.Label();
            this.UIDlabel = new System.Windows.Forms.Label();
            this.InventButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(325, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 744);
            this.panel3.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Serve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 668);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.InventButton);
            this.panel1.Controls.Add(this.cafe);
            this.panel1.Controls.Add(this.Rolelabel);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.OrdersButton);
            this.panel1.Controls.Add(this.DashButton);
            this.panel1.Controls.Add(this.Fnamelabel);
            this.panel1.Controls.Add(this.Unamelabel);
            this.panel1.Controls.Add(this.UIDlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 808);
            this.panel1.TabIndex = 23;
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
            // Rolelabel
            // 
            this.Rolelabel.AutoSize = true;
            this.Rolelabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolelabel.ForeColor = System.Drawing.Color.White;
            this.Rolelabel.Location = new System.Drawing.Point(184, 208);
            this.Rolelabel.Name = "Rolelabel";
            this.Rolelabel.Size = new System.Drawing.Size(109, 17);
            this.Rolelabel.TabIndex = 10;
            this.Rolelabel.Text = "Role : Barista";
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
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(105)))), ((int)(((byte)(6)))));
            this.OrdersButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersButton.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.Location = new System.Drawing.Point(0, 386);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(310, 36);
            this.OrdersButton.TabIndex = 4;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
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
            // Fnamelabel
            // 
            this.Fnamelabel.AutoSize = true;
            this.Fnamelabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fnamelabel.ForeColor = System.Drawing.Color.White;
            this.Fnamelabel.Location = new System.Drawing.Point(5, 284);
            this.Fnamelabel.Name = "Fnamelabel";
            this.Fnamelabel.Size = new System.Drawing.Size(282, 17);
            this.Fnamelabel.TabIndex = 3;
            this.Fnamelabel.Text = "Full Name : Samantha Kyla Calayag";
            // 
            // Unamelabel
            // 
            this.Unamelabel.AutoSize = true;
            this.Unamelabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unamelabel.ForeColor = System.Drawing.Color.White;
            this.Unamelabel.Location = new System.Drawing.Point(5, 245);
            this.Unamelabel.Name = "Unamelabel";
            this.Unamelabel.Size = new System.Drawing.Size(155, 17);
            this.Unamelabel.TabIndex = 2;
            this.Unamelabel.Text = "Username : Sam_02";
            // 
            // UIDlabel
            // 
            this.UIDlabel.AutoSize = true;
            this.UIDlabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIDlabel.ForeColor = System.Drawing.Color.White;
            this.UIDlabel.Location = new System.Drawing.Point(5, 208);
            this.UIDlabel.Name = "UIDlabel";
            this.UIDlabel.Size = new System.Drawing.Size(99, 17);
            this.UIDlabel.TabIndex = 1;
            this.UIDlabel.Text = "User ID : 03";
            // 
            // InventButton
            // 
            this.InventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(105)))), ((int)(((byte)(6)))));
            this.InventButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventButton.ForeColor = System.Drawing.Color.White;
            this.InventButton.Location = new System.Drawing.Point(0, 447);
            this.InventButton.Name = "InventButton";
            this.InventButton.Size = new System.Drawing.Size(310, 36);
            this.InventButton.TabIndex = 27;
            this.InventButton.Text = "Inventory";
            this.InventButton.UseVisualStyleBackColor = false;
            this.InventButton.Click += new System.EventHandler(this.InventButton_Click);
            // 
            // BOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 808);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOrders";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cafe;
        private System.Windows.Forms.Label Rolelabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button DashButton;
        private System.Windows.Forms.Label Fnamelabel;
        private System.Windows.Forms.Label Unamelabel;
        private System.Windows.Forms.Label UIDlabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button InventButton;
    }
}