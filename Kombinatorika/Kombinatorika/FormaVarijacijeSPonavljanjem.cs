using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kombinatorika
{
    public partial class FormaVarijacijeSPonavljanjem : Form
    {
        public FormaVarijacijeSPonavljanjem()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            double n = Convert.ToInt32(txtN.Text);
            double k = Convert.ToInt32(txtK.Text);

            txtRjesenje.Text =Convert.ToString(Math.Pow(n, k));
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FormaPocetna frm = new FormaPocetna();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
    }
}
