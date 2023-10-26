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
    public partial class UC_ViewUser : UserControl
    {
        

        function fn = new function();
        string query;
        string currnetuser = "";
        public UC_ViewUser()
        {
            InitializeComponent();
        }
    
        public string ID
        {
            set { currnetuser = value; }
        }
        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
           DataSet ds= fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select *from users where Username like '" + txtUsername.Text + "%'";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        string username;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {


                username = DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            
            }
            catch { }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete Confirmation  !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                if (currnetuser != username)
                {
                    query = "delete from users where Username='" + username + "'";
                    fn.setData(query, "User Record Deleated.");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete \n Your own profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
       
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }
    }
}
