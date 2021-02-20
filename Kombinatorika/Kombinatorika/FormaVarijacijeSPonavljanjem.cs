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
            //deklaracija varijabli
            double n;
            double k;

            //***************provjere dali su upisane vrijednosti brojevi i dali su vrjednost null***************
            bool provjeraN = double.TryParse(txtN.Text, out n);
            bool provjeraK = double.TryParse(txtK.Text, out k);

            if (string.IsNullOrEmpty(txtN.Text)|| string.IsNullOrEmpty(txtK.Text) || !provjeraN || !provjeraK)
            {
                MessageBox.Show("Krivo ste upisali podatke", "Greška");
                return;
            }
            //****************************************************************************************************

            //izračin formule i ispis rješenja
            txtRjesenje.Text =Convert.ToString(Math.Pow(n, k));
        }

        //povratak na početnu formu
        private void btnNazad_Click(object sender, EventArgs e)
        {
            FormaPocetna frm = new FormaPocetna();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
    }
}
