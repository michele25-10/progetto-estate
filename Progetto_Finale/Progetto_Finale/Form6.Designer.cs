namespace Progetto_Finale
{
    partial class Form_Modalità_Di_Gioco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Modalità_Di_Gioco));
            this.Facile_btn = new System.Windows.Forms.Button();
            this.Difficile_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Facile_btn
            // 
            this.Facile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facile_btn.Location = new System.Drawing.Point(319, 232);
            this.Facile_btn.Name = "Facile_btn";
            this.Facile_btn.Size = new System.Drawing.Size(165, 51);
            this.Facile_btn.TabIndex = 0;
            this.Facile_btn.Text = "Facile";
            this.Facile_btn.UseVisualStyleBackColor = true;
            this.Facile_btn.Click += new System.EventHandler(this.Facile_btn_Click);
            // 
            // Difficile_btn
            // 
            this.Difficile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficile_btn.Location = new System.Drawing.Point(319, 310);
            this.Difficile_btn.Name = "Difficile_btn";
            this.Difficile_btn.Size = new System.Drawing.Size(165, 51);
            this.Difficile_btn.TabIndex = 1;
            this.Difficile_btn.Text = "Difficile";
            this.Difficile_btn.UseVisualStyleBackColor = true;
            this.Difficile_btn.Click += new System.EventHandler(this.Difficile_btn_Click);
            // 
            // Form_Modalità_Di_Gioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 488);
            this.Controls.Add(this.Difficile_btn);
            this.Controls.Add(this.Facile_btn);
            this.Name = "Form_Modalità_Di_Gioco";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Facile_btn;
        private System.Windows.Forms.Button Difficile_btn;
    }
}