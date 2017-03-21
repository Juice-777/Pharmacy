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
    public partial class ProvidersAll : Form
    {
        public ProvidersAll()
        {
            InitializeComponent();
        }

        private void ProvidersAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aptekaDB.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.aptekaDB.Providers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProviderCorrect pcf = new ProviderCorrect();
            pcf.Show();
        }
    }
}
