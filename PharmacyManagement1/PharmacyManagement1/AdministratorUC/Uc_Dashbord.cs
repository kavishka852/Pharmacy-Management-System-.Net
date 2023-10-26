using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement1.AdministratorUC
{
    public partial class Uc_Dashbord : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Uc_Dashbord()
        {
            InitializeComponent();
        }

        private void Uc_Dashbord_Load(object sender, EventArgs e)
        {
            query = "SELECT COUNT(UserRole) FROM users WHERE UserRole = 'Administrator'";
            ds = fn.getData(query);
            setLabel(ds, AdminLabel);

            query = "SELECT COUNT(UserRole) FROM users WHERE UserRole = 'Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, PharLebal);

        }

        private void setLabel(DataSet ds,Label lbl)
        {
            if(ds.Tables[0].Rows.Count!=0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Uc_Dashbord_Load(this, null);
        }
    }
}
