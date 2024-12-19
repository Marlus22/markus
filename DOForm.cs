using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class DOForm : Form
    {
        public DOForm()
        {
            InitializeComponent();
        }


        private void DineButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetOrderForm SetOrderForm = new SetOrderForm();
            SetOrderForm.ShowDialog();
        }

        private void TakeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetOrderForm SetOrderForm = new SetOrderForm();
            SetOrderForm.ShowDialog();
        }
    }
}
