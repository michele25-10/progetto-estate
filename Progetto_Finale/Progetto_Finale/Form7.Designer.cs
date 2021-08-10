namespace Progetto_Finale
{
    partial class Form_Schermata_Gioco_Difficile
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer;
            this.Punteggio_txt = new System.Windows.Forms.Label();
            this.Timer_txt = new System.Windows.Forms.Label();
            this.Pausa_btn = new System.Windows.Forms.Button();
            this.ScarafaggioNero_btn = new System.Windows.Forms.Button();
            this.ScarafaggioVerde_btn = new System.Windows.Forms.Button();
            this.ScarafaggioRosso_btn = new System.Windows.Forms.Button();
            timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Punteggio_txt
            // 
            this.Punteggio_txt.AutoSize = true;
            this.Punteggio_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punteggio_txt.Location = new System.Drawing.Point(417, 28);
            this.Punteggio_txt.Name = "Punteggio_txt";
            this.Punteggio_txt.Size = new System.Drawing.Size(0, 25);
            this.Punteggio_txt.TabIndex = 1;
            // 
            // Timer_txt
            // 
            this.Timer_txt.AutoSize = true;
            this.Timer_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_txt.Location = new System.Drawing.Point(740, 28);
            this.Timer_txt.Name = "Timer_txt";
            this.Timer_txt.Size = new System.Drawing.Size(0, 25);
            this.Timer_txt.TabIndex = 2;
            // 
            // Pausa_btn
            // 
            this.Pausa_btn.BackColor = System.Drawing.Color.Transparent;
            this.Pausa_btn.BackgroundImage = global::Progetto_Finale.Properties.Resources.pause__1_;
            this.Pausa_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pausa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pausa_btn.Location = new System.Drawing.Point(12, 12);
            this.Pausa_btn.Name = "Pausa_btn";
            this.Pausa_btn.Size = new System.Drawing.Size(57, 45);
            this.Pausa_btn.TabIndex = 3;
            this.Pausa_btn.UseVisualStyleBackColor = false;
            this.Pausa_btn.Click += new System.EventHandler(this.Pausa_btn_Click);
            // 
            // ScarafaggioNero_btn
            // 
            this.ScarafaggioNero_btn.BackColor = System.Drawing.Color.Transparent;
            this.ScarafaggioNero_btn.BackgroundImage = global::Progetto_Finale.Properties.Resources.ScarafaggioNero_;
            this.ScarafaggioNero_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScarafaggioNero_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScarafaggioNero_btn.Location = new System.Drawing.Point(209, 282);
            this.ScarafaggioNero_btn.Name = "ScarafaggioNero_btn";
            this.ScarafaggioNero_btn.Size = new System.Drawing.Size(72, 64);
            this.ScarafaggioNero_btn.TabIndex = 4;
            this.ScarafaggioNero_btn.UseVisualStyleBackColor = false;
            this.ScarafaggioNero_btn.Click += new System.EventHandler(this.ScarafaggioNero_btn_Click);
            // 
            // ScarafaggioVerde_btn
            // 
            this.ScarafaggioVerde_btn.BackColor = System.Drawing.Color.Transparent;
            this.ScarafaggioVerde_btn.BackgroundImage = global::Progetto_Finale.Properties.Resources.bruco;
            this.ScarafaggioVerde_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScarafaggioVerde_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScarafaggioVerde_btn.Location = new System.Drawing.Point(436, 282);
            this.ScarafaggioVerde_btn.Name = "ScarafaggioVerde_btn";
            this.ScarafaggioVerde_btn.Size = new System.Drawing.Size(73, 64);
            this.ScarafaggioVerde_btn.TabIndex = 5;
            this.ScarafaggioVerde_btn.UseVisualStyleBackColor = false;
            this.ScarafaggioVerde_btn.Visible = false;
            this.ScarafaggioVerde_btn.Click += new System.EventHandler(this.ScarafaggioVerde_btn_Click);
            // 
            // ScarafaggioRosso_btn
            // 
            this.ScarafaggioRosso_btn.BackColor = System.Drawing.Color.Transparent;
            this.ScarafaggioRosso_btn.BackgroundImage = global::Progetto_Finale.Properties.Resources.ScarafaggioRossoForm;
            this.ScarafaggioRosso_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScarafaggioRosso_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScarafaggioRosso_btn.Location = new System.Drawing.Point(564, 282);
            this.ScarafaggioRosso_btn.Name = "ScarafaggioRosso_btn";
            this.ScarafaggioRosso_btn.Size = new System.Drawing.Size(82, 64);
            this.ScarafaggioRosso_btn.TabIndex = 6;
            this.ScarafaggioRosso_btn.UseVisualStyleBackColor = false;
            this.ScarafaggioRosso_btn.Visible = false;
            this.ScarafaggioRosso_btn.Click += new System.EventHandler(this.ScarafaggioRosso_btn_Click);
            // 
            // Form_Schermata_Gioco_Difficile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Progetto_Finale.Properties.Resources.Schermata_gioco_sfondo;
            this.ClientSize = new System.Drawing.Size(903, 494);
            this.Controls.Add(this.ScarafaggioRosso_btn);
            this.Controls.Add(this.ScarafaggioVerde_btn);
            this.Controls.Add(this.ScarafaggioNero_btn);
            this.Controls.Add(this.Pausa_btn);
            this.Controls.Add(this.Timer_txt);
            this.Controls.Add(this.Punteggio_txt);
            this.Name = "Form_Schermata_Gioco_Difficile";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Punteggio_txt;
        private System.Windows.Forms.Label Timer_txt;
        private System.Windows.Forms.Button Pausa_btn;
        private System.Windows.Forms.Button ScarafaggioNero_btn;
        private System.Windows.Forms.Button ScarafaggioVerde_btn;
        private System.Windows.Forms.Button ScarafaggioRosso_btn;
    }
}