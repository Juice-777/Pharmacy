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
    public partial class ToSale : Form
    {
        public ToSale()
        {
            InitializeComponent();
        }

        private void ToSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB.Medicaments' table. You can move, or remove it, as needed.
            this.medicamentsTableAdapter.Fill(this.aptekaDB.Medicaments);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm1 = new SqlCommand("SELECT Art FROM [dbo].[Medicaments] WHERE Art = '" + cb_Art.Text + "'", sqlConnection1);
            sqlConnection1.Open();
            cb_Art.Text = Comm1.ExecuteScalar().ToString();
            sqlConnection1.Close();

            SqlConnection sqlConnection6 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm6 = new SqlCommand("SELECT Name FROM [dbo].[Medicaments] WHERE Art = '" + cb_Art.Text + "'", sqlConnection6);
            sqlConnection6.Open();
            tb_Name.Text = Comm6.ExecuteScalar().ToString();
            sqlConnection6.Close();

            SqlConnection sqlConnection4 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm4 = new SqlCommand("SELECT [Group] FROM [dbo].[Medicaments] WHERE Art = '" + cb_Art.Text + "'", sqlConnection4);
            sqlConnection4.Open();
            tb_Group.Text = Comm4.ExecuteScalar().ToString();
            sqlConnection4.Close();

            SqlConnection sqlConnection3 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm3 = new SqlCommand("SELECT Form FROM [dbo].[Medicaments] WHERE Art = '" + cb_Art.Text + "'", sqlConnection3);
            sqlConnection3.Open();
            tb_Form.Text = Comm3.ExecuteScalar().ToString();
            sqlConnection3.Close();

            SqlConnection sqlConnection5 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm5 = new SqlCommand("SELECT Amount FROM [dbo].[Medicaments] WHERE Art = '" + cb_Art.Text + "'", sqlConnection5);
            sqlConnection5.Open();
            tb_Amount.Text = Comm5.ExecuteScalar().ToString();
            sqlConnection5.Close();

            SqlConnection sqlConnection7 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm7 = new SqlCommand("SELECT (Price*1.2) FROM [Phapm].[dbo].[Buy] WHERE Art = '" + cb_Art.Text + "'", sqlConnection7);
            sqlConnection7.Open();
            tb_Price.Text = Comm7.ExecuteScalar().ToString();
            sqlConnection5.Close();
            
        }

        float Zine = 0;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Phapm].[dbo].[Saling] ([Art], [Name], [Price], [Total]) VALUES (@art, @name, @total, @price)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@art", cb_Art.Text);
            sqlCommand.Parameters.AddWithValue("@name", tb_Name.Text);
            sqlCommand.Parameters.AddWithValue("@total", tb_Total.Text);
            sqlCommand.Parameters.AddWithValue("@price", tb_Price.Text);
            sqlCommand.ExecuteNonQuery();


            SqlConnection sqlConnection7 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            string query = "select * from [Phapm].[dbo].[Saling]";
            SqlCommand cmd7 = new SqlCommand(query, sqlConnection7);
            SqlDataAdapter da = new SqlDataAdapter(cmd7);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Insert to formated table 
            SqlConnection sqlConnection2 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            sqlConnection2.Open();
            SqlCommand sqlCommand2 = new SqlCommand("INSERT INTO [Phapm].[dbo].[SalingFormated] ([Art], [Name], [Price], [Total], [Date]) VALUES (@art, @name, @price, @total, @date )", sqlConnection2);

            int Art = Convert.ToInt32(cb_Art.Text);
            Art = int.Parse(Art.ToString());
            float Price = Convert.ToSingle(tb_Price.Text);
            MessageBox.Show("" + Price+"");
            int Total = Convert.ToInt32(tb_Total.Text);
            DateTime now = DateTime.Now;
            
            sqlCommand2.Parameters.AddWithValue("@art", Art);
            sqlCommand2.Parameters.AddWithValue("@name", tb_Name.Text);
            sqlCommand2.Parameters.AddWithValue("@price", Math.Round(Price, 2));
            sqlCommand2.Parameters.AddWithValue("@total", Total);
            sqlCommand2.Parameters.AddWithValue("@date", now);
            sqlCommand2.ExecuteNonQuery();

            Zine += Price;
            label8.Text = Zine.ToString();
        
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentsTableAdapter.FillBy2(this.aptekaDB.Medicaments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection7 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            string query = "TRUNCATE TABLE [Phapm].[dbo].[Saling]";
            SqlCommand cmd7 = new SqlCommand(query, sqlConnection7);
            SqlDataAdapter da = new SqlDataAdapter(cmd7);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            string query1 = "TRUNCATE TABLE [Phapm].[dbo].[SalingFormated]";
            SqlCommand cmd1 = new SqlCommand(query1, sqlConnection1);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Phapm].[dbo].[Sale] ([Art], [Name], [Price], [Total], [Date]) SELECT [Art], [Name], [Price], [Total], [Date] FROM [Phapm].[dbo].[SalingFormated]", sqlConnection);
            sqlCommand.ExecuteNonQuery();

            //Удаление с временныъх таблиц
            SqlConnection sqlConnection7 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            string query = "TRUNCATE TABLE [Phapm].[dbo].[Saling]";
            SqlCommand cmd7 = new SqlCommand(query, sqlConnection7);
            SqlDataAdapter da = new SqlDataAdapter(cmd7);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            string query1 = "TRUNCATE TABLE [Phapm].[dbo].[SalingFormated]";
            SqlCommand cmd1 = new SqlCommand(query1, sqlConnection1);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            MessageBox.Show("Saled!", "Info");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicamentsBase mdb = new MedicamentsBase();
            mdb.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand Comm1 = new SqlCommand("SELECT * FROM [dbo].[Medicaments] WHERE  Name LIKE '%" + tb_Name.Text + "%'", sqlConnection1);

            SqlDataAdapter da = new SqlDataAdapter(Comm1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
