using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Apteka
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.aptekaDB.Login);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection con;
            con = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO LOGIN (LOGIN, PASSWORD) VALUES (@username, @password)", con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("User '" + textBox1.Text + "' is added!", "Info");

            SqlConnection sqlConnection2 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            string query = "select * from LOGIN";
            SqlCommand cmd2 = new SqlCommand(query, sqlConnection2);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM LOGIN WHERE Login = '" + comboBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

                MessageBox.Show("User '" + comboBox1.Text  + "' is deleted!", "Info");

            SqlConnection sqlConnection2 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            string query = "select * from Login";
            SqlCommand cmd2 = new SqlCommand(query, sqlConnection2);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
