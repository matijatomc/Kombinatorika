﻿namespace Kombinatorika
{
    partial class FormaVarijacijeBezPonavljanja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtRjesenje = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(71, 91);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 3;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(71, 133);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 4;
            // 
            // txtRjesenje
            // 
            this.txtRjesenje.Location = new System.Drawing.Point(12, 250);
            this.txtRjesenje.Name = "txtRjesenje";
            this.txtRjesenje.Size = new System.Drawing.Size(100, 20);
            this.txtRjesenje.TabIndex = 5;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.FlatAppearance.BorderSize = 0;
            this.btnIzracunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzracunaj.Image = global::Kombinatorika.Properties.Resources.Izracunaj;
            this.btnIzracunaj.Location = new System.Drawing.Point(12, 159);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(114, 17);
            this.btnIzracunaj.TabIndex = 7;
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.FlatAppearance.BorderSize = 0;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Image = global::Kombinatorika.Properties.Resources.Nazad;
            this.btnNazad.Location = new System.Drawing.Point(709, 416);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(79, 22);
            this.btnNazad.TabIndex = 8;
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // FormaVarijacijeBezPonavljanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kombinatorika.Properties.Resources.varijacije__bez_ponavljanja;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.txtRjesenje);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormaVarijacijeBezPonavljanja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HyperMath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtRjesenje;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnNazad;
    }
}