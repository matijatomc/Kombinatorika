namespace Kombinatorika
{
    partial class FormaPermutacijeBezPonavljanja
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
            this.txtRjesenje = new System.Windows.Forms.TextBox();
            this.btnIzračunaj = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(54, 92);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 2;
            // 
            // txtRjesenje
            // 
            this.txtRjesenje.Location = new System.Drawing.Point(12, 236);
            this.txtRjesenje.Name = "txtRjesenje";
            this.txtRjesenje.ReadOnly = true;
            this.txtRjesenje.Size = new System.Drawing.Size(100, 20);
            this.txtRjesenje.TabIndex = 3;
            // 
            // btnIzračunaj
            // 
            this.btnIzračunaj.FlatAppearance.BorderSize = 0;
            this.btnIzračunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzračunaj.Image = global::Kombinatorika.Properties.Resources.Izracunaj;
            this.btnIzračunaj.Location = new System.Drawing.Point(12, 118);
            this.btnIzračunaj.Name = "btnIzračunaj";
            this.btnIzračunaj.Size = new System.Drawing.Size(114, 19);
            this.btnIzračunaj.TabIndex = 5;
            this.btnIzračunaj.UseVisualStyleBackColor = true;
            this.btnIzračunaj.Click += new System.EventHandler(this.btnIzračunaj_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.FlatAppearance.BorderSize = 0;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Image = global::Kombinatorika.Properties.Resources.Nazad;
            this.btnNazad.Location = new System.Drawing.Point(710, 415);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(78, 23);
            this.btnNazad.TabIndex = 6;
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // FormaPermutacijeBezPonavljanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kombinatorika.Properties.Resources.permutacija_bez_ponavljanja;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnIzračunaj);
            this.Controls.Add(this.txtRjesenje);
            this.Controls.Add(this.txtN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormaPermutacijeBezPonavljanja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HyperMath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtRjesenje;
        private System.Windows.Forms.Button btnIzračunaj;
        private System.Windows.Forms.Button btnNazad;
    }
}