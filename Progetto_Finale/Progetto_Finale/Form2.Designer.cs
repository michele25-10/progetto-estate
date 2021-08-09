namespace Progetto_Finale
{
    partial class Form_Schermata_Gioco
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
            this.Pausa_btn = new System.Windows.Forms.Button();
            this.Punteggio_txt = new System.Windows.Forms.Label();
            this.Timer_txt = new System.Windows.Forms.Label();
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
            // Pausa_btn
            // 
            this.Pausa_btn.BackColor = System.Drawing.Color.Transparent;
            this.Pausa_btn.BackgroundImage = global::Progetto_Finale.Properties.Resources.pause__1_;
            this.Pausa_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pausa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pausa_btn.Location = new System.Drawing.Point(9, 6);
            this.Pausa_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Pausa_btn.Name = "Pausa_btn";
            this.Pausa_btn.Size = new System.Drawing.Size(56, 38);
            this.Pausa_btn.TabIndex = 6;
            this.Pausa_btn.UseVisualStyleBackColor = false;
            this.Pausa_btn.Click += new System.EventHandler(this.Pausa_btn_Click);
            // 
            // Punteggio_txt
            // 
            this.Punteggio_txt.AutoSize = true;
            this.Punteggio_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punteggio_txt.Location = new System.Drawing.Point(255, 8);
            this.Punteggio_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Punteggio_txt.Name = "Punteggio_txt";
            this.Punteggio_txt.Size = new System.Drawing.Size(0, 26);
            this.Punteggio_txt.TabIndex = 4;
            // 
            // Timer_txt
            // 
            this.Timer_txt.AutoSize = true;
            this.Timer_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_txt.Location = new System.Drawing.Point(532, 8);
            this.Timer_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Timer_txt.Name = "Timer_txt";
            this.Timer_txt.Size = new System.Drawing.Size(0, 26);
            this.Timer_txt.TabIndex = 7;
            this.Timer_txt.Click += new System.EventHandler(this.Timer_txt_Click);
            // 
            // ScarafaggioNero_btn
            // 
            this.ScarafaggioNero_btn.BackColor = System.Drawing.Color.Transparent;
            this.ScarafaggioNero_btn.BackgroundImage = global::Progetto_Finale.Properties.Resources.ScarafaggioNero_;
            this.ScarafaggioNero_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScarafaggioNero_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScarafaggioNero_btn.Location = new System.Drawing.Point(172, 222);
            this.ScarafaggioNero_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ScarafaggioNero_btn.Name = "ScarafaggioNero_btn";
            this.ScarafaggioNero_btn.Size = new System.Drawing.Size(63, 60);
            this.ScarafaggioNero_btn.TabIndex = 11;
            this.ScarafaggioNero_btn.UseVisualStyleBackColor = false;
            this.ScarafaggioNero_btn.Click += new System.EventHandler(this.ScarafaggioNero_btn_Click);
            // 
            // ScarafaggioVerde_btn
            // 
            this.ScarafaggioVerde_btn.BackColor = System.Drawing.Color.Transparent;
            this.ScarafaggioVerde_btn.BackgroundImage = global::Progetto_Finale.Properties.Resources.bruco;
            this.ScarafaggioVerde_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScarafaggioVerde_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScarafaggioVerde_btn.Location = new System.Drawing.Point(276, 222);
            this.ScarafaggioVerde_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ScarafaggioVerde_btn.Name = "ScarafaggioVerde_btn";
            this.ScarafaggioVerde_btn.Size = new System.Drawing.Size(60, 60);
            this.ScarafaggioVerde_btn.TabIndex = 12;
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
            this.ScarafaggioRosso_btn.Location = new System.Drawing.Point(353, 222);
            this.ScarafaggioRosso_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ScarafaggioRosso_btn.Name = "ScarafaggioRosso_btn";
            this.ScarafaggioRosso_btn.Size = new System.Drawing.Size(71, 60);
            this.ScarafaggioRosso_btn.TabIndex = 13;
            this.ScarafaggioRosso_btn.UseVisualStyleBackColor = false;
            this.ScarafaggioRosso_btn.Visible = false;
            this.ScarafaggioRosso_btn.Click += new System.EventHandler(this.ScarafaggioRosso_btn_Click);
            // 
            // Form_Schermata_Gioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Progetto_Finale.Properties.Resources.Schermata_gioco_sfondo;
            this.ClientSize = new System.Drawing.Size(650, 465);
            this.Controls.Add(this.ScarafaggioRosso_btn);
            this.Controls.Add(this.ScarafaggioVerde_btn);
            this.Controls.Add(this.ScarafaggioNero_btn);
            this.Controls.Add(this.Timer_txt);
            this.Controls.Add(this.Pausa_btn);
            this.Controls.Add(this.Punteggio_txt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Schermata_Gioco";
            this.Text = "+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Schermata_Gioco_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Pausa_btn;
        private System.Windows.Forms.Label Punteggio_txt;
        private System.Windows.Forms.Label Timer_txt;
        private System.Windows.Forms.Button ScarafaggioNero_btn;
        private System.Windows.Forms.Button ScarafaggioVerde_btn;
        private System.Windows.Forms.Button ScarafaggioRosso_btn;
    }
}