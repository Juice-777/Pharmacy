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
    public partial class DeleteMed : Form
    {
        public DeleteMed()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteMed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB.Medicaments' table. You can move, or remove it, as needed.
            this.medicamentsTableAdapter.Fill(this.aptekaDB.Medicaments);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM [dbo].[Medicaments] WHERE Art = '" + comboBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            SqlConnection sqlConnection2 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            string query = "select * from [dbo].[Medicaments]";
            SqlCommand cmd = new SqlCommand(query, sqlConnection2);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm1 = new SqlCommand("SELECT Art FROM [dbo].[Medicaments] WHERE Art = '" + comboBox1.Text + "'", sqlConnection1);
            sqlConnection1.Open();
            comboBox1.Text = Comm1.ExecuteScalar().ToString();
            sqlConnection1.Close();

            SqlConnection sqlConnection6 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm6 = new SqlCommand("SELECT Name FROM [dbo].[Medicaments] WHERE Art = '" + comboBox1.Text + "'", sqlConnection6);
            sqlConnection6.Open();
            tb_Name.Text = Comm6.ExecuteScalar().ToString();
            sqlConnection6.Close();

            SqlConnection sqlConnection4 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm4 = new SqlCommand("SELECT [Group] FROM [dbo].[Medicaments] WHERE Art = '" + comboBox1.Text + "'", sqlConnection4);
            sqlConnection4.Open();
            tb_Group.Text = Comm4.ExecuteScalar().ToString();
            sqlConnection4.Close();

            SqlConnection sqlConnection3 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm3 = new SqlCommand("SELECT Form FROM [dbo].[Medicaments] WHERE Art = '" + comboBox1.Text + "'", sqlConnection3);
            sqlConnection3.Open();
            tb_form.Text = Comm3.ExecuteScalar().ToString();
            sqlConnection3.Close();

            SqlConnection sqlConnection5 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm5 = new SqlCommand("SELECT Amount FROM [dbo].[Medicaments] WHERE Art = '" + comboBox1.Text + "'", sqlConnection5);
            sqlConnection5.Open();
            tb_amount.Text = Comm5.ExecuteScalar().ToString();
            sqlConnection5.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentsTableAdapter.FillBy(this.aptekaDB.Medicaments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
