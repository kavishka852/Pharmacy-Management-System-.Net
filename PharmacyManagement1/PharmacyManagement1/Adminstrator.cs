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
    public partial class Adminstrator : Form
    {
        string user = "";
        public Adminstrator()
        {
            InitializeComponent();
        }
        public string ID

        {
            get { return user.ToString(); }
        }
        public Adminstrator(String Username)
        {
            InitializeComponent();
            userNameLabel.Text = Username;
            user = Username;
            uC_ViewUser1.ID = ID;
            uC_Profile1.ID = ID;
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            uc_Dashbord1.Visible = true;
            uc_Dashbord1.BringToFront();
        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uc_Dashbord1.Visible = false;
            uC_AddUser1.Visible= false;
            uC_ViewUser1.Visible = false;
            uC_Profile1.Visible = false;
            btndash.PerformClick();
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }
    }
}
