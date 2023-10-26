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
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {

            String UserRole = ComboBoxuserrole.Text;
            String Name = txtname.Text;
            String Dob = dateTimePicker1.Text;
            Int64 Mobile = Int64.Parse(txtmobileno.Text);
            String Email = txtemailaddress.Text;
            String Username = txtusername.Text;
            string Pass = txtpassword.Text;

            try
            {
                query = "INSERT INTO users (UserRole,Name,Dob,Mobile,Email,Username,Pass) VALUES ('" + UserRole + "','" + Name + "','" + Dob + "'," + Mobile + ",'" + Email + "','" + Username + "','" + Pass + "')";
                fn.setData(query, "Sign up SUCCESSFUL.");
            }
            catch(Exception)
            {
                MessageBox.Show("Username Allready exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtname.Clear();
            dateTimePicker1.ResetText();
            txtmobileno.Clear();
            txtemailaddress.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            ComboBoxuserrole.SelectedIndex = -1;
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where Username ='" + txtusername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\Users\User\Desktop\vs19\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\User\Desktop\vs19\no.png";
            }
        }
    }
}
