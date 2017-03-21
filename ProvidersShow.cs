using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class ProvidersShow : Form
    {
        private object providerTableAdapter;

        public ProvidersShow()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProvidersShow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB.Provider' table. You can move, or remove it, as needed.
            //providerTableAdapter.Fill(aptekaDB.Provider);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProviderAdd provAddF = new ProviderAdd();
            provAddF.Show();
        }
    }
}
