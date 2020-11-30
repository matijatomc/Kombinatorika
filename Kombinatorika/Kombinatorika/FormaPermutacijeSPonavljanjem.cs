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
        public int[] k= new int[100];

        private void btnUnesiR_Click(object sender, EventArgs e)
        {
            Formule a = new Formule();
            r = Convert.ToInt32(txtR.Text);
            txtR.ReadOnly = true;

            
            k[brc] = a.Permutacije(Convert.ToInt32(txtK.Text));
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
            int n = a.Permutacije(Convert.ToInt32(txtN.Text));
            int kRjesenje=1;

            for(int i = 0; i < r; i++)
            {
                kRjesenje = kRjesenje * k[i];
            }
            txtRjesenje.Text = Convert.ToString(n / kRjesenje);
        }
    }
}
