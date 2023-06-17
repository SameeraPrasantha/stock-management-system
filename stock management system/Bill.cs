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
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dbStockManage;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public void getBillNumber() {
            try
            {
                cmd = new SqlCommand("SELECT TOP 1 BillNo FROM Bill ORDER BY BillNo DESC;", con);
                con.Open();
                SqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {
                    string num;
                    num = DR1.GetValue(0).ToString();
                    int getNumber = int.Parse(num);
                    getNumber = int.Parse(txtBillNo.Text);
                    int cal = getNumber + 1;
                    txtBillNo.Text = cal.ToString();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
            }
        }

        public Bill()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.MdiParent = this.MdiParent;
            mn.Show();
            this.Hide();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            dtBill.Value = DateTime.Today;
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
