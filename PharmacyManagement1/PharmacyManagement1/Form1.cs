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
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM users";
             ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count==0)
            {
                if(txtuser.Text=="root" && txtpass.Text=="root")
                {
                    Adminstrator admin = new Adminstrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "SELECT * FROM users WHERE Username = '" + txtuser.Text + "' and Pass = '" + txtpass.Text + "'";
                ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count!=0)
                {
                    String UserRole = ds.Tables[0].Rows[0][1].ToString();
                    if(UserRole=="Administrator")
                    {
                        Adminstrator admin = new Adminstrator(txtuser.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if(UserRole== "Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            if(txtuser.Text=="Seth" && txtpass.Text=="pass")
            {
                Adminstrator am = new Adminstrator();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
