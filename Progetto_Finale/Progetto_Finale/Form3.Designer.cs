namespace Progetto_Finale
{
    partial class Form_Schermata_Pausa
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
            this.Ricomincia_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Classifica_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ricomincia_btn
            // 
            this.Ricomincia_btn.Location = new System.Drawing.Point(307, 187);
            this.Ricomincia_btn.Name = "Ricomincia_btn";
            this.Ricomincia_btn.Size = new System.Drawing.Size(178, 53);
            this.Ricomincia_btn.TabIndex = 3;
            this.Ricomincia_btn.Text = "Ricomincia";
            this.Ricomincia_btn.UseVisualStyleBackColor = true;
            this.Ricomincia_btn.Click += new System.EventHandler(this.Ricomincia_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(307, 353);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(178, 59);
            this.Home_btn.TabIndex = 4;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Classifica_btn
            // 
            this.Classifica_btn.Location = new System.Drawing.Point(307, 265);
            this.Classifica_btn.Name = "Classifica_btn";
            this.Classifica_btn.Size = new System.Drawing.Size(178, 55);
            this.Classifica_btn.TabIndex = 5;
            this.Classifica_btn.Text = "Classifica";
            this.Classifica_btn.UseVisualStyleBackColor = true;
            this.Classifica_btn.Click += new System.EventHandler(this.Classifica_btn_Click);
            // 
            // Form_Schermata_Pausa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Progetto_Finale.Properties.Resources.Schermata_Pausa_Form__1_;
            this.ClientSize = new System.Drawing.Size(710, 491);
            this.Controls.Add(this.Classifica_btn);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.Ricomincia_btn);
            this.Name = "Form_Schermata_Pausa";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Ricomincia_btn;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button Classifica_btn;
    }
}