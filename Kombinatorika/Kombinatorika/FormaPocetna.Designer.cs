namespace Kombinatorika
{
    partial class FormaPocetna
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
            this.btnPermutacijaS = new System.Windows.Forms.Button();
            this.btnPermutacijeBez = new System.Windows.Forms.Button();
            this.btnVarijacijeS = new System.Windows.Forms.Button();
            this.btnVarijacijeBez = new System.Windows.Forms.Button();
            this.btnKonbinacijeS = new System.Windows.Forms.Button();
            this.btnKonbinacijeBez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPermutacijaS
            // 
            this.btnPermutacijaS.Location = new System.Drawing.Point(50, 77);
            this.btnPermutacijaS.Name = "btnPermutacijaS";
            this.btnPermutacijaS.Size = new System.Drawing.Size(88, 47);
            this.btnPermutacijaS.TabIndex = 0;
            this.btnPermutacijaS.Text = "Permutacije s ponavljanjem";
            this.btnPermutacijaS.UseVisualStyleBackColor = true;
            this.btnPermutacijaS.Click += new System.EventHandler(this.btnPermutacijaS_Click);
            // 
            // btnPermutacijeBez
            // 
            this.btnPermutacijeBez.Location = new System.Drawing.Point(184, 77);
            this.btnPermutacijeBez.Name = "btnPermutacijeBez";
            this.btnPermutacijeBez.Size = new System.Drawing.Size(90, 47);
            this.btnPermutacijeBez.TabIndex = 1;
            this.btnPermutacijeBez.Text = "Permutacije bez ponavljanja";
            this.btnPermutacijeBez.UseVisualStyleBackColor = true;
            this.btnPermutacijeBez.Click += new System.EventHandler(this.btnPermutacijeBez_Click);
            // 
            // btnVarijacijeS
            // 
            this.btnVarijacijeS.Location = new System.Drawing.Point(50, 142);
            this.btnVarijacijeS.Name = "btnVarijacijeS";
            this.btnVarijacijeS.Size = new System.Drawing.Size(88, 41);
            this.btnVarijacijeS.TabIndex = 2;
            this.btnVarijacijeS.Text = "Varijacije s ponavljanjem";
            this.btnVarijacijeS.UseVisualStyleBackColor = true;
            this.btnVarijacijeS.Click += new System.EventHandler(this.btnVarijacijeS_Click);
            // 
            // btnVarijacijeBez
            // 
            this.btnVarijacijeBez.Location = new System.Drawing.Point(184, 141);
            this.btnVarijacijeBez.Name = "btnVarijacijeBez";
            this.btnVarijacijeBez.Size = new System.Drawing.Size(90, 42);
            this.btnVarijacijeBez.TabIndex = 3;
            this.btnVarijacijeBez.Text = "Varijacije bez ponavljanja";
            this.btnVarijacijeBez.UseVisualStyleBackColor = true;
            this.btnVarijacijeBez.Click += new System.EventHandler(this.btnVarijacijeBez_Click);
            // 
            // btnKonbinacijeS
            // 
            this.btnKonbinacijeS.Location = new System.Drawing.Point(50, 207);
            this.btnKonbinacijeS.Name = "btnKonbinacijeS";
            this.btnKonbinacijeS.Size = new System.Drawing.Size(88, 36);
            this.btnKonbinacijeS.TabIndex = 4;
            this.btnKonbinacijeS.Text = "Kombinacije s ponavljanjem";
            this.btnKonbinacijeS.UseVisualStyleBackColor = true;
            this.btnKonbinacijeS.Click += new System.EventHandler(this.btnKonbinacijeS_Click);
            // 
            // btnKonbinacijeBez
            // 
            this.btnKonbinacijeBez.Location = new System.Drawing.Point(184, 207);
            this.btnKonbinacijeBez.Name = "btnKonbinacijeBez";
            this.btnKonbinacijeBez.Size = new System.Drawing.Size(90, 36);
            this.btnKonbinacijeBez.TabIndex = 5;
            this.btnKonbinacijeBez.Text = "Kombinacije bez ponavljanja";
            this.btnKonbinacijeBez.UseVisualStyleBackColor = true;
            this.btnKonbinacijeBez.Click += new System.EventHandler(this.btnKonbinacijeBez_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Odaberite što bi ste htjeli:";
            // 
            // FormaPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKonbinacijeBez);
            this.Controls.Add(this.btnKonbinacijeS);
            this.Controls.Add(this.btnVarijacijeBez);
            this.Controls.Add(this.btnVarijacijeS);
            this.Controls.Add(this.btnPermutacijeBez);
            this.Controls.Add(this.btnPermutacijaS);
            this.Name = "FormaPocetna";
            this.Text = "Kombinatorika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPermutacijaS;
        private System.Windows.Forms.Button btnPermutacijeBez;
        private System.Windows.Forms.Button btnVarijacijeS;
        private System.Windows.Forms.Button btnVarijacijeBez;
        private System.Windows.Forms.Button btnKonbinacijeS;
        private System.Windows.Forms.Button btnKonbinacijeBez;
        private System.Windows.Forms.Label label1;
    }
}

