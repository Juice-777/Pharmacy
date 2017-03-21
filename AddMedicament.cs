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
    public partial class AddMedicament : Form
    {
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;

        public AddMedicament()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=NOUT;Initial Catalog=Phapm;Integrated Security=True");
            sqlConnection.Open();
            sqlCommand = new SqlCommand("INSERT INTO [dbo].[Medicaments] (Art, Name, Form, [Group], Amount ) VALUES (@art, @name, @form, @group, @amount)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@art", tb_ArtNom.Text);
            sqlCommand.Parameters.AddWithValue("@name", tb_Name.Text);
            sqlCommand.Parameters.AddWithValue("@form", cb_Form.Text);
            sqlCommand.Parameters.AddWithValue("@group", cb_Group.Text);
            sqlCommand.Parameters.AddWithValue("@amount", cb_Amount.Text);
            sqlCommand.ExecuteNonQuery();

            this.Hide();
        }

        private void tb_ArtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
