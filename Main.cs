using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Apteka
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            MedicamentsBase prodForm = new MedicamentsBase();
            prodForm.Show();
        }

        private void btn_addPreparate_Click(object sender, EventArgs e)
        {
            AddMedicament addMF = new AddMedicament();
            addMF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteMed delForm = new DeleteMed();
            delForm.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn loginForm = new LogIn();
            loginForm.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            AddUser addUsF = new AddUser();
            addUsF.Show();
        }

        private void btn_AddProv_Click(object sender, EventArgs e)
        {
            ProviderCorrect prAdd = new ProviderCorrect();
            prAdd.Show();
        }

        private void btn_DeleteProv_Click(object sender, EventArgs e)
        {
            ProvidersAll prsowF = new ProvidersAll();
            prsowF.Show();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            Buy buyForm = new Buy();
            buyForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 2.1", "Pharmacy");
        }

        private void adressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kyiv city, str. Belaj 8\nmob +38 (068) 860-08-07\ncity (044) 587-84-77", "Contacts");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToSale ts = new ToSale();
            ts.Show();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Bought bf = new Bought();
            bf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sales sf = new Sales();
            sf.Show();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Stock stF = new Stock();
            stF.Show();
        }
    }
}
