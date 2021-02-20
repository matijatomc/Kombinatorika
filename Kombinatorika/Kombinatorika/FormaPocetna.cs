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
    public partial class FormaPocetna : Form
    {
        
        public FormaPocetna()
        {
            InitializeComponent();
        }

        //Pokretanje forme permutacije s ponavljanjem
        private void btnPermutacijaS_Click(object sender, EventArgs e)
        {
            FormaPermutacijeSPonavljanjem frm = new FormaPermutacijeSPonavljanjem();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
        //Pokretanje forme permutacije bez ponavljanja
        private void btnPermutacijeBez_Click(object sender, EventArgs e)
        {
            FormaPermutacijeBezPonavljanja frm = new FormaPermutacijeBezPonavljanja();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
        //Pokretanje forme varijacije s ponavljanjem
        private void btnVarijacijeS_Click(object sender, EventArgs e)
        {
            FormaVarijacijeSPonavljanjem frm = new FormaVarijacijeSPonavljanjem();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
        //Pokretanje forme varijacije bez ponavljanja
        private void btnVarijacijeBez_Click(object sender, EventArgs e)
        {
            FormaVarijacijeBezPonavljanja frm = new FormaVarijacijeBezPonavljanja();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
        //Pokretanje forme konbinacije s ponavljanjem
        private void btnKonbinacijeS_Click(object sender, EventArgs e)
        {
            FormaKombinacijeSPonavljanjem frm = new FormaKombinacijeSPonavljanjem();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
        //Pokretanje forme konbinacije bez ponavljanja
        private void btnKonbinacijeBez_Click(object sender, EventArgs e)
        {
            FormaKombinacijeBezPonavljanja frm = new FormaKombinacijeBezPonavljanja();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }

    }
}
