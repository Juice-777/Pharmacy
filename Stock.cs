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
    public partial class Stock : Form
    {

        public Stock()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.aptekaDB.Sale);
            // TODO: This line of code loads data into the 'aptekaDB.Buy' table. You can move, or remove it, as needed.
            this.buyTableAdapter.Fill(this.aptekaDB.Buy);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.saleTableAdapter.FillBy(this.aptekaDB.Sale);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void queryStockToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.buyTableAdapter.QueryStock(this.aptekaDB.Buy);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.buyTableAdapter.FillBy(this.aptekaDB.Buy);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.buyTableAdapter.FillBy1(this.aptekaDB.Buy);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {

            try
                {
                dataGridView1.AutoGenerateColumns = true;

                SqlConnection conn = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                //SqlDataReader datareader;
                cmd.CommandText = "SELECT dbo.Buy.Name, dbo.Buy.Amount, dbo.Buy.Form, ISNULL (dbo.Buy.Total, 0) - ISNULL (dbo.Sale.Total, 0) AS Stock FROM dbo.Buy Left JOIN dbo.Sale ON dbo.Buy.id = dbo.Sale.id";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }

            catch (Exception ex)
                 {
                     MessageBox.Show("Error " + ex);
                 }
            
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_Exit_Click_2(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
