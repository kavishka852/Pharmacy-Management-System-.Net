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
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void ComboBox1Check_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboBox1Check.SelectedIndex==0)
            {
                query = "SELECT * FROM Medic WHERE Edate >= getdate()";
                setDataGridView(query, "Valid Medicine", Color.Black);
            }
            else if(ComboBox1Check.SelectedIndex == 1)
            {
                query = "SELECT * FROM Medic WHERE Edate <= getdate()";
                setDataGridView(query, "Expired Medicines", Color.Red);
            }
            else if(ComboBox1Check.SelectedIndex == 2)
            {
                query = "SELECT * FROM Medic";
                setDataGridView(query, "", Color.Black);
            }
        }

        private void setDataGridView(String query,String lableName,Color col)
        {
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
            labelSet.Text = lableName;
            labelSet.ForeColor = col;
        }
        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            labelSet.Text = "";

        }
    }
}
