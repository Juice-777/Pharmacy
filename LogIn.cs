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
using System.Data.Sql;

namespace Apteka
{
    public partial class LogIn: Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void lbl_logo_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [Login] where Login = '" + txtbx_login.Text + "' and [Password] ='" + txtbx_password .Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main mainForm = new Main();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Error login or password! \nPlease retry.", "Info");
            }
        }

        private void txtbx_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pharmacy 2.1\nby Ilya Shubin", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
