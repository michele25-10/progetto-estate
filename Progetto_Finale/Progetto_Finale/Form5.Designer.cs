namespace Progetto_Finale
{
    partial class Form_Schermata_Classifica
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
            this.Classifica_dgv = new System.Windows.Forms.DataGridView();
            this.Posizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punteggio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Home_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Classifica_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Classifica_dgv
            // 
            this.Classifica_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Classifica_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posizione,
            this.NomePlayer,
            this.Punteggio});
            this.Classifica_dgv.Location = new System.Drawing.Point(249, 168);
            this.Classifica_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.Classifica_dgv.Name = "Classifica_dgv";
            this.Classifica_dgv.RowTemplate.Height = 24;
            this.Classifica_dgv.Size = new System.Drawing.Size(313, 122);
            this.Classifica_dgv.TabIndex = 0;
            this.Classifica_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Classifica_dgv_CellContentClick);
            // 
            // Posizione
            // 
            this.Posizione.Frozen = true;
            this.Posizione.HeaderText = "Posizione";
            this.Posizione.Name = "Posizione";
            // 
            // NomePlayer
            // 
            this.NomePlayer.Frozen = true;
            this.NomePlayer.HeaderText = "Nome Player";
            this.NomePlayer.Name = "NomePlayer";
            // 
            // Punteggio
            // 
            this.Punteggio.Frozen = true;
            this.Punteggio.HeaderText = "Punteggio";
            this.Punteggio.Name = "Punteggio";
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(364, 362);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 1;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Form_Schermata_Classifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Progetto_Finale.Properties.Resources.Schermata_Classifica_Form;
            this.ClientSize = new System.Drawing.Size(708, 490);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.Classifica_dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Schermata_Classifica";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form_Schermata_Classifica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Classifica_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Classifica_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punteggio;
        private System.Windows.Forms.Button Home_btn;
    }
}