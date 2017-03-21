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
    public partial class ProviderCorrect : Form
    {
        public ProviderCorrect()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection con;
            con = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO PROVIDERS (NAME, PHONE) VALUES (@name, @phone)", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@phone", textBox2.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("User '" + textBox1.Text + "' with phone nomber '"+ textBox2.Text + "' is added!", "Info");

            this.Hide();
            ProviderCorrect pcf = new ProviderCorrect();
            pcf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM PROVIDERS WHERE Name = '" + comboBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("User '" + comboBox1.Text + "' is deleted!", "Info");

            this.Hide();
            ProviderCorrect pcf = new ProviderCorrect();
            pcf.Show();
        }

        private void ProviderCorrect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.aptekaDB.Providers);

        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProvidersAll prsowF = new ProvidersAll();
            prsowF.Show();
        }
    }
}
