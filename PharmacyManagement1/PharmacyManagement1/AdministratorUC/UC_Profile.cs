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
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        string query;
        public UC_Profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { UsernameLabel.Text = value; }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String UserRole = ComboBoxUser.Text;
            String Name = txtName.Text;
            String Dob = txtDOB.Text;
            Int64 Mobile = Int64.Parse(txtMobile.Text);
            String Email = txtEmail.Text;
            String Username = UsernameLabel.Text;
            string Pass = txtPass.Text;

            query = "update users set UserRole ='" + UserRole + "',Name ='" + Name + "',Dob ='" + Dob + "',Mobile ='" + Mobile + "',Email ='" + Email + "',Username ='" + Username + "',Pass ='" + Pass + "' where Username = '" + Username + "'";
            fn.setData(query, "Profile Updation Successful.");
        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query="select * from users where username='"+UsernameLabel.Text+"'";
           DataSet ds= fn.getData(query);
            ComboBoxUser.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDOB.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPass.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }
    }
}
