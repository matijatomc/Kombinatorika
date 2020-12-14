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
    public partial class FormaKombinacijeSPonavljanjem : Form
    {
        public FormaKombinacijeSPonavljanjem()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            Formule a = new Formule();
            float n;
            float k;
            float rjesenje;

            bool provjeraN = float.TryParse(txtN.Text, out n);
            bool provjeraK = float.TryParse(txtK.Text, out k);

            if (string.IsNullOrEmpty(txtN.Text) || string.IsNullOrEmpty(txtK.Text) || !provjeraN || !provjeraK)
            {
                MessageBox.Show("Krivo ste upisali podatke", "Greška");
            }
            
            n = n + k - 1;

            rjesenje = a.Permutacije(n - k);
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
