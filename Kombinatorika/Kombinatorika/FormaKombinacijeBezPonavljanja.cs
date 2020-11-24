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
    public partial class FormaKombinacijeBezPonavljanja : Form
    {
        public FormaKombinacijeBezPonavljanja()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            Formule a = new Formule();
            int n = Convert.ToInt32(txtN.Text);
            int k = Convert.ToInt32(txtK.Text);

            int rjesenje = a.Permutacije(n - k);
            n = a.Permutacije(n);
            k = a.Permutacije(k);

            txtRjesenje.Text = Convert.ToString(n / (k * rjesenje));
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
