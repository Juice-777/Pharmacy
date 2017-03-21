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
    public partial class MedicamentsBase : Form
    {
        public MedicamentsBase()
        {
            InitializeComponent();
        }

        private void MedicamentsBase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB.Medicaments' table. You can move, or remove it, as needed.
            this.medicamentsTableAdapter.Fill(this.aptekaDB.Medicaments);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentsTableAdapter.FillBy1(this.aptekaDB.Medicaments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy5ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentsTableAdapter.FillBy5(this.aptekaDB.Medicaments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy6ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentsTableAdapter.FillBy6(this.aptekaDB.Medicaments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy7ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentsTableAdapter.FillBy7(this.aptekaDB.Medicaments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy8ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentsTableAdapter.FillBy8(this.aptekaDB.Medicaments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy9ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentsTableAdapter.FillBy9(this.aptekaDB.Medicaments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked) && (checkBox2.Checked))     //All Providers + All Arts
            {
                SqlConnection conn = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader datareader;
                //SELECT id, Art, Name, Form, [Group], Amount FROM dbo.Medicaments
                cmd.CommandText = "SELECT * FROM dbo.Medicaments";
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


            else if (checkBox1.Checked)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader datareader;
                cmd.CommandText = "SELECT * FROM dbo.Medicaments WHERE [Group] = '" + comboBox2.Text + "'";
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
                cmd.CommandText = "SELECT * FROM dbo.Medicaments WHERE Form = '" + comboBox1.Text + "'";
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
                cmd.CommandText = "SELECT * FROM  dbo.Medicaments WHERE Form = '" + comboBox1.Text + "'AND [Group] = '" + comboBox2.Text + "'";
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
    }
    
}
