namespace Progetto_Finale
{
    partial class Form_Schermata_iniziale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomePlayer_txt = new System.Windows.Forms.TextBox();
            this.Play_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomePlayer_txt
            // 
            this.NomePlayer_txt.Location = new System.Drawing.Point(258, 221);
            this.NomePlayer_txt.Name = "NomePlayer_txt";
            this.NomePlayer_txt.Size = new System.Drawing.Size(191, 20);
            this.NomePlayer_txt.TabIndex = 0;
            // 
            // Play_btn
            // 
            this.Play_btn.Location = new System.Drawing.Point(309, 359);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(96, 30);
            this.Play_btn.TabIndex = 1;
            this.Play_btn.Text = "Play";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // Form_Schermata_iniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Progetto_Finale.Properties.Resources.Sfondo_Form_Home_;
            this.ClientSize = new System.Drawing.Size(712, 491);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.NomePlayer_txt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Schermata_iniziale";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomePlayer_txt;
        private System.Windows.Forms.Button Play_btn;
    }
}

