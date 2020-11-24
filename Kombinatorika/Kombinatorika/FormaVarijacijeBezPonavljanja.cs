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
    public partial class FormaVarijacijeBezPonavljanja : Form
    {
        public FormaVarijacijeBezPonavljanja()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            Formule a = new Formule();

            int n = Convert.ToInt32(txtN.Text);
            int k = Convert.ToInt32(txtK.Text);

            k = a.Permutacije(n - k);
            n = a.Permutacije(n);

            txtRjesenje.Text = Convert.ToString(n / k);
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
