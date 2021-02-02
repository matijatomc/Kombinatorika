namespace Kombinatorika
{
    partial class FormaPermutacijeSPonavljanjem
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
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnUnesiK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(53, 232);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 6;
            this.txtN.Visible = false;
            // 
            // txtRjesenje
            // 
            this.txtRjesenje.Location = new System.Drawing.Point(12, 292);
            this.txtRjesenje.Name = "txtRjesenje";
            this.txtRjesenje.ReadOnly = true;
            this.txtRjesenje.Size = new System.Drawing.Size(100, 20);
            this.txtRjesenje.TabIndex = 7;
            this.txtRjesenje.Visible = false;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(53, 188);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 11;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(12, 125);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 2;
            // 
            // btnNazad
            // 
            this.btnNazad.FlatAppearance.BorderSize = 0;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Image = global::Kombinatorika.Properties.Resources.Nazad;
            this.btnNazad.Location = new System.Drawing.Point(707, 415);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(81, 23);
            this.btnNazad.TabIndex = 9;
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.BackgroundImage = global::Kombinatorika.Properties.Resources.Izracunaj;
            this.btnIzracunaj.FlatAppearance.BorderSize = 0;
            this.btnIzracunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzracunaj.Location = new System.Drawing.Point(189, 231);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(118, 20);
            this.btnIzracunaj.TabIndex = 8;
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Visible = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnUnesiK
            // 
            this.btnUnesiK.FlatAppearance.BorderSize = 0;
            this.btnUnesiK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesiK.Image = global::Kombinatorika.Properties.Resources.UNESITE;
            this.btnUnesiK.Location = new System.Drawing.Point(189, 184);
            this.btnUnesiK.Name = "btnUnesiK";
            this.btnUnesiK.Size = new System.Drawing.Size(90, 27);
            this.btnUnesiK.TabIndex = 3;
            this.btnUnesiK.UseVisualStyleBackColor = true;
            this.btnUnesiK.Click += new System.EventHandler(this.btnUnesiR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kombinatorika.Properties.Resources.crno;
            this.pictureBox1.Location = new System.Drawing.Point(12, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 54);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormaPermutacijeSPonavljanjem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Kombinatorika.Properties.Resources.permutacija_s_ponavljanjem;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.txtRjesenje);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnUnesiK);
            this.Controls.Add(this.txtR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormaPermutacijeSPonavljanjem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HyperMath";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUnesiK;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtRjesenje;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}