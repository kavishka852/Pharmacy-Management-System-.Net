using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement1.PharmacistUC
{
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            
            
            query = "select Mname from Medic where Edate >= getdate() and Quantity >'0'";
            ds = fn.getData(query);
            listBoxmedicine.Items.Clear(); 

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxmedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            listBoxmedicine.Items.Clear();
            query = "select Mname from Medic where Mname like '" + txtSearchBox.Text + "%' and Edate >= getdate() and Quantity >'0'";
            ds = fn.getData(query);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxmedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxmedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoUnit.Clear();

            String name = listBoxmedicine.GetItemText(listBoxmedicine.SelectedItem);

            txtName.Text = name;
            query = "select Mid,Edate,Perunit from Medic where Mname='" + name + "'";
            ds = fn.getData(query);
            txtMid.Text = ds.Tables[0].Rows[0][0].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0][1].ToString();
            txtUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNoUnit_TextChanged(object sender, EventArgs e)
        {
            if (txtNoUnit.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoUnit.Text);
                Int64 totalAmount = unitPrice * noOfUnit;
                txtTotal.Text = totalAmount.ToString();
            }
            else
            {
                txtTotal.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (txtMid.Text != "")
            {
                query = "select  Quantity from Medic where Mid='" + txtMid.Text + "'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtNoUnit.Text);

                if (newQuantity >= 0)
                {
                    n = DataGridView1.Rows.Add();
                    DataGridView1.Rows[n].Cells[0].Value = txtMid.Text;
                    DataGridView1.Rows[n].Cells[1].Value = txtName.Text;
                    DataGridView1.Rows[n].Cells[2].Value = dateTimePicker1.Text;
                    DataGridView1.Rows[n].Cells[3].Value = txtUnit.Text;
                    DataGridView1.Rows[n].Cells[4].Value = txtNoUnit.Text;
                    DataGridView1.Rows[n].Cells[5].Value = txtTotal.Text;

                    totalAmount = totalAmount + int.Parse(txtTotal.Text);
                    labelTotal.Text = "Rs." + totalAmount.ToString();

                    query = "Update Medic set quantity='" + newQuantity + "' where Mid='" + txtMid.Text + "'";
                    fn.setData(query, "Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock.\n Only" + quantity + "Left", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_P_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           

        }

        private void clearAll()
        {
            txtMid.Clear();
            txtName.Clear();
            dateTimePicker1.ResetText();
            txtUnit.Clear();
            txtNoUnit.Clear();
        }
    }
}
