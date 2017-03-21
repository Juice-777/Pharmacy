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
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.aptekaDB.Providers);
            // TODO: This line of code loads data into the 'aptekaDB.Medicaments' table. You can move, or remove it, as needed.
            this.medicamentsTableAdapter.Fill(this.aptekaDB.Medicaments);

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
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection6 = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            sqlConnection6.Open();
            SqlCommand sqlCommand6 = new SqlCommand("INSERT INTO Buy (Art, Name, Total, Price, Date, Provider, Amount, Form) VALUES (@art, @name, @total, @price, @date, @provider, @amount, @form)", sqlConnection6);
            sqlCommand6.Parameters.AddWithValue("@art", cb_Art.Text);
            sqlCommand6.Parameters.AddWithValue("@name", tb_Name.Text);
            sqlCommand6.Parameters.AddWithValue("@total", tb_Total.Text);
            sqlCommand6.Parameters.AddWithValue("@price", tb_Price.Text);
            sqlCommand6.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            sqlCommand6.Parameters.AddWithValue("@provider", cb_Provider.Text);
            sqlCommand6.Parameters.AddWithValue("@amount", tb_Amount.Text);
            sqlCommand6.Parameters.AddWithValue("@form", tb_Form.Text);
            sqlCommand6.ExecuteNonQuery();

            MessageBox.Show("Successfully added ", "Info");
        }

        private void tb_Form_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Amount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
