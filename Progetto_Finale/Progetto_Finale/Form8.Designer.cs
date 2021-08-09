namespace Progetto_Finale
{
    partial class Form_Schermata_Punteggio_Difficile
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
            this.PunteggioFinale_txt = new System.Windows.Forms.Label();
            this.ScarafaggiNeriSchiacciati_txt = new System.Windows.Forms.Label();
            this.ScarafaggiVerdiSchiacciati_txt = new System.Windows.Forms.Label();
            this.ScarafaggiRossiSchiacciati_txt = new System.Windows.Forms.Label();
            this.Classifica_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PunteggioFinale_txt
            // 
            this.PunteggioFinale_txt.AutoSize = true;
            this.PunteggioFinale_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunteggioFinale_txt.Location = new System.Drawing.Point(413, 189);
            this.PunteggioFinale_txt.Name = "PunteggioFinale_txt";
            this.PunteggioFinale_txt.Size = new System.Drawing.Size(0, 25);
            this.PunteggioFinale_txt.TabIndex = 0;
            // 
            // ScarafaggiNeriSchiacciati_txt
            // 
            this.ScarafaggiNeriSchiacciati_txt.AutoSize = true;
            this.ScarafaggiNeriSchiacciati_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScarafaggiNeriSchiacciati_txt.Location = new System.Drawing.Point(486, 246);
            this.ScarafaggiNeriSchiacciati_txt.Name = "ScarafaggiNeriSchiacciati_txt";
            this.ScarafaggiNeriSchiacciati_txt.Size = new System.Drawing.Size(0, 20);
            this.ScarafaggiNeriSchiacciati_txt.TabIndex = 1;
            // 
            // ScarafaggiVerdiSchiacciati_txt
            // 
            this.ScarafaggiVerdiSchiacciati_txt.AutoSize = true;
            this.ScarafaggiVerdiSchiacciati_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScarafaggiVerdiSchiacciati_txt.Location = new System.Drawing.Point(498, 275);
            this.ScarafaggiVerdiSchiacciati_txt.Name = "ScarafaggiVerdiSchiacciati_txt";
            this.ScarafaggiVerdiSchiacciati_txt.Size = new System.Drawing.Size(0, 20);
            this.ScarafaggiVerdiSchiacciati_txt.TabIndex = 2;
            // 
            // ScarafaggiRossiSchiacciati_txt
            // 
            this.ScarafaggiRossiSchiacciati_txt.AutoSize = true;
            this.ScarafaggiRossiSchiacciati_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScarafaggiRossiSchiacciati_txt.Location = new System.Drawing.Point(498, 304);
            this.ScarafaggiRossiSchiacciati_txt.Name = "ScarafaggiRossiSchiacciati_txt";
            this.ScarafaggiRossiSchiacciati_txt.Size = new System.Drawing.Size(0, 20);
            this.ScarafaggiRossiSchiacciati_txt.TabIndex = 3;
            // 
            // Classifica_btn
            // 
            this.Classifica_btn.Location = new System.Drawing.Point(418, 374);
            this.Classifica_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Classifica_btn.Name = "Classifica_btn";
            this.Classifica_btn.Size = new System.Drawing.Size(80, 33);
            this.Classifica_btn.TabIndex = 9;
            this.Classifica_btn.Text = "Classifica";
            this.Classifica_btn.UseVisualStyleBackColor = true;
            this.Classifica_btn.Click += new System.EventHandler(this.Classifica_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(288, 374);
            this.Home_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(54, 33);
            this.Home_btn.TabIndex = 8;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Form_Schermata_Punteggio_Difficile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Progetto_Finale.Properties.Resources.Schermata_Punteggio_Form_Finale;
            this.ClientSize = new System.Drawing.Size(709, 497);
            this.Controls.Add(this.Classifica_btn);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.ScarafaggiRossiSchiacciati_txt);
            this.Controls.Add(this.ScarafaggiVerdiSchiacciati_txt);
            this.Controls.Add(this.ScarafaggiNeriSchiacciati_txt);
            this.Controls.Add(this.PunteggioFinale_txt);
            this.Name = "Form_Schermata_Punteggio_Difficile";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form_Schermata_Punteggio_Difficile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PunteggioFinale_txt;
        private System.Windows.Forms.Label ScarafaggiNeriSchiacciati_txt;
        private System.Windows.Forms.Label ScarafaggiVerdiSchiacciati_txt;
        private System.Windows.Forms.Label ScarafaggiRossiSchiacciati_txt;
        private System.Windows.Forms.Button Classifica_btn;
        private System.Windows.Forms.Button Home_btn;
    }
}