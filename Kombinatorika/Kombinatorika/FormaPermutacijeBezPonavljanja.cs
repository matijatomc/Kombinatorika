using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kombinatorika;

namespace Kombinatorika 
{
    public partial class FormaPermutacijeBezPonavljanja : Form
    {
        public FormaPermutacijeBezPonavljanja()
        {
            InitializeComponent();
        }

        private void btnIzračunaj_Click(object sender, EventArgs e)
        {
            //deklariranje objekta Formule
            Formule a = new Formule();

            //deklariranje varijable
            float n;

            //provjere dali su upisane vrijednosti brojevi i dali su vrjednost null
            bool provjeraN = float.TryParse(txtN.Text, out n);
            
            if (string.IsNullOrEmpty(txtN.Text) ||  !provjeraN )
            {
                MessageBox.Show("Krivo ste upisali podatke", "Greška");
                return;
            }
            //********************************************************************

            //izračun formule
            n = a.Permutacije(n);

            //ispis rješenja
            txtRjesenje.Text =Convert.ToString(n);
        }

        //povratak na početnu formulu 
        private void btnNazad_Click(object sender, EventArgs e)
        {
            FormaPocetna frm = new FormaPocetna();
            this.Hide();
            DialogResult rez = frm.ShowDialog(); 
            this.Close();
            
        }
    }
}
