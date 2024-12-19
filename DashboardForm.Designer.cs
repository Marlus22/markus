
namespace LoginForm
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cafe = new System.Windows.Forms.PictureBox();
            this.Rolelabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.APButton = new System.Windows.Forms.Button();
            this.POSButton = new System.Windows.Forms.Button();
            this.InventButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.DashButton = new System.Windows.Forms.Button();
            this.Fnamelabel = new System.Windows.Forms.Label();
            this.Unamelabel = new System.Windows.Forms.Label();
            this.UIDlabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TotaIlabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TotIlabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ToIlabel = new System.Windows.Forms.Label();
            this.TIlabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ToUlabel = new System.Windows.Forms.Label();
            this.UserNolabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToClabel = new System.Windows.Forms.Label();
            this.CusNolabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.DTlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.cafe);
            this.panel1.Controls.Add(this.Rolelabel);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.HistoryButton);
            this.panel1.Controls.Add(this.APButton);
            this.panel1.Controls.Add(this.POSButton);
            this.panel1.Controls.Add(this.InventButton);
            this.panel1.Controls.Add(this.UserButton);
            this.panel1.Controls.Add(this.DashButton);
            this.panel1.Controls.Add(this.Fnamelabel);
            this.panel1.Controls.Add(this.Unamelabel);
            this.panel1.Controls.Add(this.UIDlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 808);
            this.panel1.TabIndex = 0;
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
            this.Rolelabel.Location = new System.Drawing.Point(192, 208);
            this.Rolelabel.Name = "Rolelabel";
            this.Rolelabel.Size = new System.Drawing.Size(103, 17);
            this.Rolelabel.TabIndex = 10;
            this.Rolelabel.Text = "Role : Admin";
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
            // Fnamelabel
            // 
            this.Fnamelabel.AutoSize = true;
            this.Fnamelabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fnamelabel.ForeColor = System.Drawing.Color.White;
            this.Fnamelabel.Location = new System.Drawing.Point(2, 284);
            this.Fnamelabel.Name = "Fnamelabel";
            this.Fnamelabel.Size = new System.Drawing.Size(279, 17);
            this.Fnamelabel.TabIndex = 3;
            this.Fnamelabel.Text = "Full Name : Kyle Gernie Del Rosario";
            // 
            // Unamelabel
            // 
            this.Unamelabel.AutoSize = true;
            this.Unamelabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unamelabel.ForeColor = System.Drawing.Color.White;
            this.Unamelabel.Location = new System.Drawing.Point(2, 245);
            this.Unamelabel.Name = "Unamelabel";
            this.Unamelabel.Size = new System.Drawing.Size(157, 17);
            this.Unamelabel.TabIndex = 2;
            this.Unamelabel.Text = "Username : Kyle_06";
            // 
            // UIDlabel
            // 
            this.UIDlabel.AutoSize = true;
            this.UIDlabel.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIDlabel.ForeColor = System.Drawing.Color.White;
            this.UIDlabel.Location = new System.Drawing.Point(2, 208);
            this.UIDlabel.Name = "UIDlabel";
            this.UIDlabel.Size = new System.Drawing.Size(99, 17);
            this.UIDlabel.TabIndex = 1;
            this.UIDlabel.Text = "User ID : 01";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(316, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 255);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.panel7.Controls.Add(this.TotaIlabel);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.TotIlabel);
            this.panel7.Location = new System.Drawing.Point(819, 26);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(237, 201);
            this.panel7.TabIndex = 1;
            // 
            // TotaIlabel
            // 
            this.TotaIlabel.AutoSize = true;
            this.TotaIlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.TotaIlabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaIlabel.ForeColor = System.Drawing.Color.White;
            this.TotaIlabel.Location = new System.Drawing.Point(155, 148);
            this.TotaIlabel.Name = "TotaIlabel";
            this.TotaIlabel.Size = new System.Drawing.Size(47, 18);
            this.TotaIlabel.TabIndex = 7;
            this.TotaIlabel.Text = "₱ 0.0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(19, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(114, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // TotIlabel
            // 
            this.TotIlabel.AutoSize = true;
            this.TotIlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.TotIlabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotIlabel.ForeColor = System.Drawing.Color.White;
            this.TotIlabel.Location = new System.Drawing.Point(50, 20);
            this.TotIlabel.Name = "TotIlabel";
            this.TotIlabel.Size = new System.Drawing.Size(143, 23);
            this.TotIlabel.TabIndex = 6;
            this.TotIlabel.Text = "Total Income";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.ToIlabel);
            this.panel6.Controls.Add(this.TIlabel);
            this.panel6.Location = new System.Drawing.Point(553, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(237, 201);
            this.panel6.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LoginForm.Properties.Resources._4634986_moneys_financial_layers_money_icon;
            this.pictureBox3.Location = new System.Drawing.Point(19, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // ToIlabel
            // 
            this.ToIlabel.AutoSize = true;
            this.ToIlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.ToIlabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToIlabel.ForeColor = System.Drawing.Color.White;
            this.ToIlabel.Location = new System.Drawing.Point(118, 166);
            this.ToIlabel.Name = "ToIlabel";
            this.ToIlabel.Size = new System.Drawing.Size(47, 18);
            this.ToIlabel.TabIndex = 4;
            this.ToIlabel.Text = "₱ 0.0";
            this.ToIlabel.Click += new System.EventHandler(this.ToIlabel_Click);
            // 
            // TIlabel
            // 
            this.TIlabel.AutoSize = true;
            this.TIlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.TIlabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIlabel.ForeColor = System.Drawing.Color.White;
            this.TIlabel.Location = new System.Drawing.Point(38, 20);
            this.TIlabel.Name = "TIlabel";
            this.TIlabel.Size = new System.Drawing.Size(166, 23);
            this.TIlabel.TabIndex = 5;
            this.TIlabel.Text = "Today\'s Income";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.ToUlabel);
            this.panel5.Controls.Add(this.UserNolabel);
            this.panel5.Location = new System.Drawing.Point(281, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 201);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LoginForm.Properties.Resources._309041_users_group_people_icon;
            this.pictureBox2.Location = new System.Drawing.Point(14, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ToUlabel
            // 
            this.ToUlabel.AutoSize = true;
            this.ToUlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.ToUlabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToUlabel.ForeColor = System.Drawing.Color.White;
            this.ToUlabel.Location = new System.Drawing.Point(43, 20);
            this.ToUlabel.Name = "ToUlabel";
            this.ToUlabel.Size = new System.Drawing.Size(154, 23);
            this.ToUlabel.TabIndex = 2;
            this.ToUlabel.Text = "Total of Users";
            // 
            // UserNolabel
            // 
            this.UserNolabel.AutoSize = true;
            this.UserNolabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.UserNolabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNolabel.ForeColor = System.Drawing.Color.White;
            this.UserNolabel.Location = new System.Drawing.Point(203, 148);
            this.UserNolabel.Name = "UserNolabel";
            this.UserNolabel.Size = new System.Drawing.Size(17, 18);
            this.UserNolabel.TabIndex = 3;
            this.UserNolabel.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.ToClabel);
            this.panel4.Controls.Add(this.CusNolabel);
            this.panel4.Location = new System.Drawing.Point(14, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 201);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginForm.Properties.Resources._9035117_person_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ToClabel
            // 
            this.ToClabel.AutoSize = true;
            this.ToClabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.ToClabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClabel.ForeColor = System.Drawing.Color.White;
            this.ToClabel.Location = new System.Drawing.Point(13, 20);
            this.ToClabel.Name = "ToClabel";
            this.ToClabel.Size = new System.Drawing.Size(204, 23);
            this.ToClabel.TabIndex = 0;
            this.ToClabel.Text = "Total of Customers";
            // 
            // CusNolabel
            // 
            this.CusNolabel.AutoSize = true;
            this.CusNolabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.CusNolabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusNolabel.ForeColor = System.Drawing.Color.White;
            this.CusNolabel.Location = new System.Drawing.Point(204, 148);
            this.CusNolabel.Name = "CusNolabel";
            this.CusNolabel.Size = new System.Drawing.Size(17, 18);
            this.CusNolabel.TabIndex = 1;
            this.CusNolabel.Text = "0";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(1366, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(27, 25);
            this.Close.TabIndex = 19;
            this.Close.Text = "X";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.DTlabel);
            this.panel3.Location = new System.Drawing.Point(316, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 476);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(14, 53);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1041, 401);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // DTlabel
            // 
            this.DTlabel.AutoSize = true;
            this.DTlabel.BackColor = System.Drawing.SystemColors.Control;
            this.DTlabel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTlabel.Location = new System.Drawing.Point(10, 15);
            this.DTlabel.Name = "DTlabel";
            this.DTlabel.Size = new System.Drawing.Size(120, 21);
            this.DTlabel.TabIndex = 20;
            this.DTlabel.Text = "Date/Time : ";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 808);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Fnamelabel;
        private System.Windows.Forms.Label Unamelabel;
        private System.Windows.Forms.Label UIDlabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button APButton;
        private System.Windows.Forms.Button POSButton;
        private System.Windows.Forms.Button InventButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button DashButton;
        private System.Windows.Forms.Label Rolelabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TotaIlabel;
        private System.Windows.Forms.Label TotIlabel;
        private System.Windows.Forms.Label TIlabel;
        private System.Windows.Forms.Label ToIlabel;
        private System.Windows.Forms.Label UserNolabel;
        private System.Windows.Forms.Label ToUlabel;
        private System.Windows.Forms.Label CusNolabel;
        private System.Windows.Forms.Label ToClabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cafe;
        private System.Windows.Forms.Label DTlabel;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}