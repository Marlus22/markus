
namespace LoginForm
{
    partial class DOForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cafe = new System.Windows.Forms.PictureBox();
            this.TakeButton = new System.Windows.Forms.Button();
            this.DineButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 95);
            this.label1.TabIndex = 28;
            this.label1.Text = "Dine In or Take Out";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.cafe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 808);
            this.panel1.TabIndex = 27;
            // 
            // cafe
            // 
            this.cafe.Image = global::LoginForm.Properties.Resources._460130162_122095454768537883_8055968607088583724_n;
            this.cafe.Location = new System.Drawing.Point(67, 192);
            this.cafe.Name = "cafe";
            this.cafe.Size = new System.Drawing.Size(409, 379);
            this.cafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cafe.TabIndex = 0;
            this.cafe.TabStop = false;
            // 
            // TakeButton
            // 
            this.TakeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.TakeButton.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeButton.ForeColor = System.Drawing.Color.White;
            this.TakeButton.Location = new System.Drawing.Point(1028, 473);
            this.TakeButton.Name = "TakeButton";
            this.TakeButton.Size = new System.Drawing.Size(232, 98);
            this.TakeButton.TabIndex = 33;
            this.TakeButton.Text = "Take Out";
            this.TakeButton.UseVisualStyleBackColor = false;
            this.TakeButton.Click += new System.EventHandler(this.TakeButton_Click);
            // 
            // DineButton
            // 
            this.DineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(48)))), ((int)(((byte)(28)))));
            this.DineButton.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DineButton.ForeColor = System.Drawing.Color.White;
            this.DineButton.Location = new System.Drawing.Point(733, 473);
            this.DineButton.Name = "DineButton";
            this.DineButton.Size = new System.Drawing.Size(232, 98);
            this.DineButton.TabIndex = 32;
            this.DineButton.Text = "Dine In";
            this.DineButton.UseVisualStyleBackColor = false;
            this.DineButton.Click += new System.EventHandler(this.DineButton_Click);
            // 
            // DOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 808);
            this.Controls.Add(this.TakeButton);
            this.Controls.Add(this.DineButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DOForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cafe;
        private System.Windows.Forms.Button TakeButton;
        private System.Windows.Forms.Button DineButton;
    }
}