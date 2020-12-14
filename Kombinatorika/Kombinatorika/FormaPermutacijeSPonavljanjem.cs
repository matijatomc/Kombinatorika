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
    public partial class FormaPermutacijeSPonavljanjem : Form
    {
        public FormaPermutacijeSPonavljanjem()
        {
            InitializeComponent();
        }
        public int brc = 0;
        public int r;
        public float[] k= new float[100];

        private void btnUnesiR_Click(object sender, EventArgs e)
        {
            Formule a = new Formule();

            bool provjeraR = int.TryParse(txtR.Text, out r);
            bool provjeraK = float.TryParse(txtK.Text, out k[brc]);

            if (string.IsNullOrEmpty(txtR.Text) || string.IsNullOrEmpty(txtK.Text) || !provjeraR  || !provjeraK )
            {
                MessageBox.Show("Krivo ste upisali podatke", "Greška");
                return;
            }
            txtR.ReadOnly = true;

            
            k[brc] = a.Permutacije(Convert.ToInt32(k[brc]));
            brc++;
            txtK.Clear();

            if (brc >= r)
            {
                MessageBox.Show("Unjeli ste sve brojeve", "Unos k", MessageBoxButtons.OK);
                txtN.Visible = true;
                txtRjesenje.Visible = true;
                btnIzracunaj.Visible = true;
                btnUnesiK.Visible = false;
                pictureBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Sljedeći", "Unos k", MessageBoxButtons.OK);
                txtK.Clear();
            }
            
            
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FormaPocetna frm = new FormaPocetna();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            Formule a = new Formule();

            float n;
            float kRjesenje=1;

            bool provjeraN = float.TryParse(txtN.Text, out n);

            if (string.IsNullOrEmpty(txtN.Text) || !provjeraN)
            {
                MessageBox.Show("Krivo ste upisali podatke", "Greška");
                return;
            }
            
            for(int i = 0; i < r; i++)
            {
                kRjesenje = kRjesenje * k[i];
            }
            txtRjesenje.Text = Convert.ToString(n / kRjesenje);
        }
    }
}
