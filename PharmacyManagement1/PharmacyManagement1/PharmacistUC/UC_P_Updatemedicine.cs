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
    public partial class UC_P_Updatemedicine : UserControl
    {
        function fn = new function();
        string query;
        public UC_P_Updatemedicine()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtmid.Text != "")
            {
                query = "select * from Medic where Mid='"+txtmid.Text+"'";
                DataSet ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtmname.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtmnumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    datem.Text=ds.Tables[0].Rows[0][4].ToString();
                    datee.Text= ds.Tables[0].Rows[0][5].ToString();
                    txtaquantity.Text= ds.Tables[0].Rows[0][6].ToString();
                    txtprice.Text= ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with ID :" + txtmid.Text + "exitst.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtmid.Clear();
            txtmname.Clear();
            txtmnumber.Clear();
            datem.ResetText();
            datee.ResetText();
            txtaquantity.Clear();
            txtprice.Clear();
            if(txtaddquantity.Text != "0")
            {
                txtaddquantity.Text = "0";
            }
            else
            {
                txtaddquantity.Text = "0";
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        Int64 totalQuantity;
        private void btnupdate_Click(object sender, EventArgs e)
        {
            string mname = txtmname.Text;
            string mnumber = txtmnumber.Text;
            string mdate = datem.Text;
            string edate = datee.Text;
            Int64 quantity = Int64.Parse(txtaquantity.Text);
            Int64 addQuantity = Int64.Parse(txtaddquantity.Text);
            Int64 perunit = Int64.Parse(txtprice.Text);

            totalQuantity = quantity + addQuantity;
            query = "update Medic set Mname='"+ mname + "',Mnumber ='"+ mnumber + "',Mdate='"+mdate+"',Edate='"+edate+ "',Quantity="+totalQuantity+ ",Perunit="+ perunit+" where Mid='"+txtmid.Text+"'";
            fn.setData(query, "Medicine Details Update.");
        }
    }
}
