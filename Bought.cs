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
    public partial class Bought : Form
    {
        public Bought()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bought_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.aptekaDB.Providers);
            // TODO: This line of code loads data into the 'aptekaDB.Medicaments' table. You can move, or remove it, as needed.
            this.medicamentsTableAdapter.Fill(this.aptekaDB.Medicaments);
            // TODO: This line of code loads data into the 'aptekaDB.Buy' table. You can move, or remove it, as needed.
            this.buyTableAdapter.Fill(this.aptekaDB.Buy);

        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked) && (checkBox2.Checked))     //All Providers + All Arts
            {
                SqlConnection conn = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader datareader;
                cmd.CommandText = "SELECT * FROM [dbo].[Buy] WHERE [Date] BETWEEN @date1 AND @date2";
                cmd.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTimePicker2.Value;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.SelectCommand.Connection = conn;
                dataAdapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;

                datareader = cmd.ExecuteReader();

                conn.Close();
            }


            else if (checkBox1.Checked)     //All Arts
            {
                SqlConnection conn = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader datareader;
                cmd.CommandText = "SELECT * FROM [dbo].[Buy] WHERE PROVIDER = '" + comboBox2.Text + "'AND [Date] BETWEEN @date1 AND @date2 ";
                cmd.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTimePicker2.Value;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.SelectCommand.Connection = conn;
                dataAdapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;

                datareader = cmd.ExecuteReader();

                conn.Close();
            }

            else if (checkBox2.Checked) //All providers
            {
                SqlConnection conn = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader datareader;
                cmd.CommandText = "SELECT * FROM [dbo].[Buy] WHERE ART = '" + comboBox1.Text + "' AND [Date] BETWEEN @date1 AND @date2";
                cmd.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTimePicker2.Value;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.SelectCommand.Connection = conn;
                dataAdapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;

                datareader = cmd.ExecuteReader();

                conn.Close();
            }

            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader datareader;
                cmd.CommandText = "SELECT * FROM [dbo].[Buy] WHERE ART = '" + comboBox1.Text + "'AND PROVIDER = '" + comboBox2.Text + "' AND [Date] BETWEEN @date1 AND @date2";
                cmd.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTimePicker2.Value;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.SelectCommand.Connection = conn;
                dataAdapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;

                datareader = cmd.ExecuteReader();

                conn.Close();
            }
        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentsTableAdapter.FillBy3(this.aptekaDB.Medicaments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void medicamentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void providersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
