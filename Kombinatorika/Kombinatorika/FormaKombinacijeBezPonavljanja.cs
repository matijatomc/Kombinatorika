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
            float n;
            float k;
            
            bool provjeraN = float.TryParse(txtN.Text, out n);
            bool provjeraK = float.TryParse(txtK.Text, out k);

            if (string.IsNullOrEmpty(txtN.Text) || string.IsNullOrEmpty(txtK.Text) || !provjeraN || !provjeraK)
            {
                MessageBox.Show("Pogrešno ste upisali podatke", "Greška");
                return;
            }

            float rjesenje= n - k;

            rjesenje = a.Permutacije(rjesenje);
            n = a.Permutacije(Convert.ToInt32(txtN.Text));
            k = a.Permutacije(Convert.ToInt32(txtK.Text));

            txtK.Text = Convert.ToString(k);
            txtN.Text = Convert.ToString(n);
            txtRjesenje.Text = Convert.ToString(rjesenje);

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
