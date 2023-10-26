using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement1
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            uC_P_Dashbord1.Visible = true;
            uC_P_Dashbord1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_Dashbord1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
            uC_P_ViewMedicines1.Visible = false;
            uC_P_Updatemedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
            
            btndash.PerformClick();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicines1.Visible = true;
            uC_P_ViewMedicines1.BringToFront();
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            uC_P_Updatemedicine1.Visible = true;
            uC_P_Updatemedicine1.BringToFront();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            uC_P_MedicineValidityCheck1.Visible = true;
            uC_P_MedicineValidityCheck1.BringToFront();
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();
        }
    }
}
