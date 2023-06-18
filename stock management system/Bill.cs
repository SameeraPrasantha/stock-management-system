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
        SqlDataReader Rdr;


        public string ItemName;
        public string SerialNumber;
        public string Quantity;

        public void getDataCombo()
        {
            con.Close();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT (CAST(ItemNumber AS nvarchar)+' - '+ItemName+' - '+CAST(SerialNumber AS nvarchar)+' - '+CAST(Quantity AS nvarchar)) AS COMBINED_COLUMN FROM GRN where Quantity > 0; ", con); 
                Rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("COMBINED_COLUMN", typeof(String));
                dt.Load(Rdr);
                cmbSelectItem.ValueMember = "COMBINED_COLUMN";
                cmbSelectItem.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Message " + ex);
                con.Close();
            }
        }

        public void getdataTextbox() {
            con.Close();
            try {
                cmd = new SqlCommand("select * from GRN where ItemNumber = @id; ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", lblItemNumber.Text);
                SqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {
                    lblSN.Text = DR1.GetValue(2).ToString();
                    txtQTY.Text = DR1.GetValue(3).ToString();
                    txtPrice.Text = DR1.GetValue(5).ToString();
                    lblItemName.Text = DR1.GetValue(1).ToString();

                }
                con.Close();



            }
            catch (Exception ex){
                MessageBox.Show("Erro " + ex);
            }
        }

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

        public void getCustomerName() {
            try
            {
                cmd = new SqlCommand("select * from Bill; ", con);
                con.Open();
                SqlDataReader DR1 = cmd.ExecuteReader();
                while (DR1.Read())
                {
                    string customerName = DR1.GetValue(3).ToString();
                    if (!cmbCustomer.Items.Contains(customerName))
                    {
                        cmbCustomer.Items.Add(customerName);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
            }
        }

        public void removeItem() {
            try
            {

                string sqlQuery = "update [GRN] set [Quantity]=0 where [SerialNumber]=@ID;";

               
                foreach (DataGridViewRow row in dataTable.Rows)
                {
                    // Retrieve data from each cell
                    string val1 = row.Cells[3].Value.ToString();
                    
                    // Execute SQL query for each row
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@ID", val1);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Erro = " + ex);
                con.Close();
            }
        }

        public void clear() {
            cmbSelectItem.Text = "";
            cmbCustomer.Text = "";
            txtWarranty.Text = "";
            txtWarranty.Text = "";
            txtPrice.Text = "";
            txtSum.Text = "";
            dataTable.Rows.Clear();

        }
       
        public Bill()
        {
            ItemName = "Item Name";
            //lblItemName.Text = SelectItemPopUp.ItemName;
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
            getBillNumber();
            getDataCombo();

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            getBillNumber();
            getDataCombo();
            getCustomerName();
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                string sqlQuery = "insert into Bill ([Date],[BillNo],[ItemName],[CustomerName],[Quantity],[SerialNumber],[Warranty],[Price]) values (@Date,@BillNo,@ItemName,@CustomerName,@Quantity,@SerialNumber,@Warranty,@Price);";
                

                foreach (DataGridViewRow row in dataTable.Rows)
                {
                    // Retrieve data from each cell
                    string val1 = row.Cells[1].Value.ToString();
                    string val2 = row.Cells[2].Value.ToString();
                    string val3 = row.Cells[3].Value.ToString();
                    string val4 = row.Cells[4].Value.ToString();
                    string val5 = row.Cells[5].Value.ToString();
                    string val6 = row.Cells[6].Value.ToString();

                    // Execute SQL query for each row
                    cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@Date", dtBill.Text);
                    cmd.Parameters.AddWithValue("@CustomerName", cmbCustomer.Text);
                    cmd.Parameters.AddWithValue("@ItemName", val1);
                    cmd.Parameters.AddWithValue("@BillNo", val2);
                    cmd.Parameters.AddWithValue("@SerialNumber", val3);
                    cmd.Parameters.AddWithValue("@Quantity", val4);
                    cmd.Parameters.AddWithValue("@Warranty", val5);
                    cmd.Parameters.AddWithValue("@Price", val6);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    removeItem();
                }
                
                getDataCombo();
                con.Close();
                MessageBox.Show("Record Save successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Same Serial Number founded " + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtBill.Text == "" || txtBillNo.Text == "" || cmbSelectItem.Text == "" || cmbCustomer.Text == "" || txtQTY.Text == "" || txtPrice.Text == ""||txtWarranty.Text =="")
            {
                MessageBox.Show("Please Fill the all ");
            }
            else
            {
                try
                {
                    int rowCount = dataTable.RowCount;
                  
                    string itemName = lblItemName.Text;
                    string billNumber = txtBillNo.Text;
                    string serialNumber = lblSN.Text;
                    string qty = txtQTY.Text;
                    string warranty = txtWarranty.Text;
                    string price = txtPrice.Text;

                    // Add a new row to the DataGridView
                    int rowIndex = dataTable.Rows.Add();

                    // Set the value of the first column in the new row to the TextBox value
                    dataTable.Rows[rowIndex].Cells[0].Value = rowCount.ToString();
                    dataTable.Rows[rowIndex].Cells[1].Value = itemName;
                    dataTable.Rows[rowIndex].Cells[2].Value = billNumber;
                    dataTable.Rows[rowIndex].Cells[3].Value = serialNumber;
                    dataTable.Rows[rowIndex].Cells[4].Value = qty;
                    dataTable.Rows[rowIndex].Cells[5].Value = warranty;
                    dataTable.Rows[rowIndex].Cells[6].Value = price;

                    int sum = 0;
                    foreach (DataGridViewRow row in dataTable.Rows)
                    {
                        if (row.Cells[6].Value != null)
                        {
                            sum += Convert.ToInt32(row.Cells[6].Value);
                        }
                      
                        txtSum.Text = sum.ToString();

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbSelectItem_TextChanged(object sender, EventArgs e)
        {
            string example = cmbSelectItem.Text;
            if(example == "")
            {

            }
            else
            {
                try
                {
                    lblItemNumber.Text = example.Substring(0, 3);
                }
                catch (Exception ex) { 
                    
                }
                
            }
            
        }

        private void cmbSelectItem_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbSelectItem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void lblItemNumber_TextChanged(object sender, EventArgs e)
        {
            getdataTextbox();
        }

        private void dataTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataTable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Check if the current cell is in the column you want to prevent duplicates in
            if (e.ColumnIndex == 3)
            {
                // Get the value entered in the current cell
                string currentValue = e.FormattedValue.ToString();

                // Check if the value already exists in the column
                foreach (DataGridViewRow row in dataTable.Rows)
                {
                    if (row.Index != e.RowIndex && row.Cells[3].Value != null && row.Cells[3].Value.ToString() == currentValue)
                    {
                        // Alert the user and cancel the edit if the value already exists
                        MessageBox.Show("Duplicate value not allowed");
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataTable.SelectedRows.Count > 0)
            {
                // Get the selected row to delete
                DataGridViewRow rowToDelete = dataTable.SelectedRows[0];

                // Delete the row
                dataTable.Rows.Remove(rowToDelete);

                int sum = 0;
                foreach (DataGridViewRow row in dataTable.Rows)
                {
                    if (row.Cells[6].Value != null)
                    {
                        sum += Convert.ToInt32(row.Cells[6].Value);
                    }

                    txtSum.Text = sum.ToString();

                }

            }
        }

        private void cmbCustomer_Click(object sender, EventArgs e)
        {
            getCustomerName();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
