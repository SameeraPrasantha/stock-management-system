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
    public partial class GRN : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dbStockManage;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public void getdata()
        {
            try
            {
                adapt = new SqlDataAdapter("SELECT * FROM GRN;", con);
                con.Open();
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGrid.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Message " + ex);
            }
        }

        public void clear() {
            txtItemNumber.Text = "";
            txtItemName.Text = "";
            txtSN.Text = "";
            txtQTY.Text = "";
            txtReceivePrice.Text = "";
            txtSellingPrice.Text = "";
            dtReceiveDate.Value = DateTime.Today;

        }
        public GRN()
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if ((txtItemNumber.Text == "") || (txtItemName.Text == "") || (txtSN.Text == "") || (txtQTY.Text == "") || (txtReceivePrice.Text == "")|| (txtSellingPrice.Text == ""))
            {
                MessageBox.Show("Please fill the fileds", "Infomation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("insert into GRN (ItemNumber,ItemName,SerialNumber,Quantity,ReceivePrice,SellingPrice,ReceiveDate)values(@ItemNumber, @ItemName, @SerialNumber, @Quantity, @ReceivePrice, @SellingPrice, @ReceiveDate)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@ItemNumber", txtItemNumber.Text);
                    cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@SerialNumber", txtSN.Text);
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQTY.Text));
                    cmd.Parameters.AddWithValue("@ReceivePrice",float.Parse( txtReceivePrice.Text));
                    cmd.Parameters.AddWithValue("@SellingPrice", float.Parse(txtSellingPrice.Text));
                    cmd.Parameters.AddWithValue("@ReceiveDate", dtReceiveDate.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(txtItemNumber.Text + " = this index number add");
                    getdata();
                    clear();
                }
                catch (Exception ex) {
                    MessageBox.Show("Record Inserted Unsuccessfully  " + ex);
                }
            }

            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 ID = Convert.ToInt32(txtItemNumber.Text);
                cmd = new SqlCommand("update [GRN] set [ItemName]=@ItemName,[SerialNumber]=@SerialNumber,[Quantity]=@Quantity,[ReceivePrice]=@ReceivePrice,[SellingPrice]=@SellingPrice,[ReceiveDate]=@ReceiveDate where [ItemNumber]=@ID;", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                cmd.Parameters.AddWithValue("@SerialNumber", txtSN.Text);
                cmd.Parameters.AddWithValue("@Quantity", txtQTY.Text);
                cmd.Parameters.AddWithValue("@ReceivePrice", txtReceivePrice.Text);
                cmd.Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text);
                cmd.Parameters.AddWithValue("@ReceiveDate", dtReceiveDate.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                getdata();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Erro = " + ex);
            }
        }

        private void GRN_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void dataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtItemNumber.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            txtItemName.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtSN.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            txtQTY.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            txtReceivePrice.Text = dataGrid.CurrentRow.Cells[4].Value.ToString();
            txtSellingPrice.Text = dataGrid.CurrentRow.Cells[5].Value.ToString();
            dtReceiveDate.Text = dataGrid.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 ID = Convert.ToInt32(txtItemNumber.Text);
                var result = MessageBox.Show("Are you want delete this record", "Warining", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    cmd = new SqlCommand("delete GRN where ItemNumber=@id;", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    getdata();
                    clear();
                }
                else
                {
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro = " + ex);
            }
        }
    }
}
