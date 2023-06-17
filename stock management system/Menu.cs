using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_management_system
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit.!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login mn = new Login();
                mn.MdiParent = this.MdiParent;
                mn.Show();
                this.Hide();
            }
        }

        private void picGRN_Click(object sender, EventArgs e)
        {
            GRN mn = new GRN();
            mn.MdiParent = this.MdiParent;
            mn.Show();
            this.Hide();
        }

        private void lblGRN_Click(object sender, EventArgs e)
        {
            GRN mn = new GRN();
            mn.MdiParent = this.MdiParent;
            mn.Show();
            this.Hide();
        }

        private void picBill_Click(object sender, EventArgs e)
        {
            Bill mn = new Bill();
            mn.MdiParent = this.MdiParent;
            mn.Show();
            this.Hide();
        }

        private void lblMakeBill_Click(object sender, EventArgs e)
        {
          
            Bill mn = new Bill();
            mn.MdiParent = this.MdiParent;
            mn.Show();
            this.Hide();

          
        }
    }
}
