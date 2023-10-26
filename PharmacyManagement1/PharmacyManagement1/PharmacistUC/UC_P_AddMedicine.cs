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
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtid.Text!= "" && txtname.Text!= "" && txtmednumber.Text!= "" && txtquantity.Text!= "" && txtprice.Text!= "")
            {
                String Mid = txtid.Text;
                String Mname = txtname.Text;
                String Mnumber = txtmednumber.Text;
                String Mdate = dateTimePicker1Man.Text;
                String Edate = dateTimePicker2Exp.Text;
                Int64 Quantity = Int64.Parse(txtquantity.Text);
                Int64 Perunit = Int64.Parse(txtprice.Text);

                query = "INSERT INTO Medic (Mid,Mname,Mnumber,Quantity,Perunit) VALUES ('"+Mid+"','"+Mname+"','"+Mnumber+"',"+Quantity+","+Perunit+")";
                fn.setData(query,"Medicine Added To Database.");
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtid.Clear();
            txtname.Clear();
            txtmednumber.Clear();
            txtquantity.Clear();
            txtprice.Clear();
            dateTimePicker1Man.ResetText();
            dateTimePicker2Exp.ResetText();
        }
    }
}
