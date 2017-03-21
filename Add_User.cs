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
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phapmDataSet.Medicaments' table. You can move, or remove it, as needed.
            this.medicamentsTableAdapter.Fill(this.phapmDataSet.Medicaments);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
