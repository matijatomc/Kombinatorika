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
        //deklaracija varijabli koje će se koristit u više metodama
        public int brc = 0;
        public int r;
        public float[] k= new float[100];
        //*********************************************************

        private void btnUnesiR_Click(object sender, EventArgs e)
        {
            //deklariranje objekta Formule
            Formule a = new Formule();

            //***************provjere dali su upisane vrijednosti brojevi i dali su vrjednost null***************
            bool provjeraR = int.TryParse(txtR.Text, out r);
            bool provjeraK = float.TryParse(txtK.Text, out k[brc]);

            if (string.IsNullOrEmpty(txtR.Text) || string.IsNullOrEmpty(txtK.Text) || !provjeraR  || !provjeraK )
            {
                MessageBox.Show("Krivo ste upisali podatke", "Greška");
                return;
            }
            //***************************************************************************************************

            //postavljanje txtR u read only tako da se r više ne može mjenjat
            txtR.ReadOnly = true;

            //permitiranje vrijednosti k i spremanje u niz 
            k[brc] = a.Permutacije(Convert.ToInt32(k[brc]));
            //povačavanje broj upisanjih brojeva u niz 
            brc++;
            //brisanje teksta u txtK 
            txtK.Clear();

            //**************provjera dali je dovoljno brojeva upisano u nizu**************
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
            //****************************************************************************
        }

        //povratak na početnu formu
        private void btnNazad_Click(object sender, EventArgs e)
        {
            FormaPocetna frm = new FormaPocetna();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            //deklariranje objekta Formule
            Formule a = new Formule();

            //deklariranje varijabli
            float n;
            float kRjesenje=1;

            //provjere dali je upisana vrijednost broj i dali je vrjednost null
            bool provjeraN = float.TryParse(txtN.Text, out n);

            if (string.IsNullOrEmpty(txtN.Text) || !provjeraN)
            {
                MessageBox.Show("Krivo ste upisali podatke", "Greška");
                return;
            }
            //*****************************************************************

            //********izračun formule********
            n = a.Permutacije(n);

            for(int i = 0; i < r; i++)
            {
                kRjesenje = kRjesenje * k[i];
            }
            //*******************************

            //ispis rješennja
            txtRjesenje.Text = Convert.ToString(n / kRjesenje);
        }
    }
}
