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
    public partial class UC_P_ViewMedicines : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_ViewMedicines()
        {
            InitializeComponent();
        }

        private void UC_P_ViewMedicines_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM Medic";
            setDataGridView(query);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM Medic WHERE Mname LIKE '"+txtsearch.Text+"%'";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        String medicineId;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM Medic WHERE Mid='" + medicineId + "'";
                fn.setData(query,"Medicine Record Deleted.");
                UC_P_ViewMedicines_Load(this, null);
            }
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_P_ViewMedicines_Load(this, null);
        }
    }
}
