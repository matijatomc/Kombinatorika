﻿using System;
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
            //deklariranje objekta Formule
            Formule a = new Formule();

            //deklariranje varijabli
            float n;
            float k;
            
            //**********provjere dali su upisane vrijednosti brojevi i dali su vrjednost null******************
            bool provjeraN = float.TryParse(txtN.Text, out n);
            bool provjeraK = float.TryParse(txtK.Text, out k);

            if (string.IsNullOrEmpty(txtN.Text) || string.IsNullOrEmpty(txtK.Text) || !provjeraN || !provjeraK)
            {
                MessageBox.Show("Pogrešno ste upisali podatke", "Greška");
                return;
            }
            //**************************************************************************************************

            //***************izračun formule**************
            float rjesenje= n - k;

            rjesenje = a.Permutacije(rjesenje);
            n = a.Permutacije(n);
            k = a.Permutacije(k);
            //********************************************

            //ispis rješenje
            txtRjesenje.Text = Convert.ToString(n / (k * rjesenje));
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
