using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_management_system
{
   
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dbStockManage;Integrated Security=True");
        SqlCommand cmd;


        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string userPassword = txtPassword.Text;

            if ((String.IsNullOrEmpty(userName) == true) && (String.IsNullOrEmpty(userPassword) == true))
            {
                MessageBox.Show("Username and Password Empty");
            }
            else if ((String.IsNullOrEmpty(userName) == true) || (String.IsNullOrEmpty(userPassword) == true))
            {
                MessageBox.Show("Username and Password Empty");
            }
            else
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM users WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Menu mn = new Menu();
                        mn.MdiParent = this.MdiParent;
                        mn.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                }

            }

                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Important Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.ExitThread();
            }
        }
    }
}
