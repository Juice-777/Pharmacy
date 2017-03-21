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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB1.Medicaments' table. You can move, or remove it, as needed.
            this.medicamentsTableAdapter.Fill(this.aptekaDB1.Medicaments);
            // TODO: This line of code loads data into the 'aptekaDB.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.aptekaDB.Sale);
            // TODO: This line of code loads data into the 'aptekaDB.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.aptekaDB.Sale);

        }

        private void btn_sort_Click(object sender, EventArgs e)
        {

        }

        private void btn_sort_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)     //All Arts
            {
                SqlConnection conn = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader datareader;
                cmd.CommandText = "SELECT * FROM [Phapm].[dbo].[Sale] WHERE [Date] BETWEEN @date1 AND @date2 ";
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
                cmd.CommandText = "SELECT * FROM [Phapm].[dbo].[Sale] WHERE ART = '" + comboBox1.Text + "'AND [Date] BETWEEN @date1 AND @date2";
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentsTableAdapter.FillBy4(this.aptekaDB.Medicaments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
