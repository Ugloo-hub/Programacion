using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=Habibi\SQLSERVER2022;Initial Catalog=userLogin;Integrated Security=True;TrustServerCertificate=True");
            string query = "select * from logins where Username ='"+textBox1.Text.Trim()+"'and Password= '"+textBox2.Text.Trim()+"'";

            SqlDataAdapter sda = new SqlDataAdapter (query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)

            {
                frmLoggedIn objfrmLoggedIn = new frmLoggedIn();
                this.Hide();
                objfrmLoggedIn.Show();

            }

            else

            {

                MessageBox.Show("Please check your username and password");

            }


        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
