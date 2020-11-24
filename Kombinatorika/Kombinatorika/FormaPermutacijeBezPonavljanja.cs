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
            Formule a = new Formule();
            int n = Convert.ToInt32( txtN.Text);
            n = a.Permutacije(n);
            txtRjesenje.Text =Convert.ToString(n);
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
