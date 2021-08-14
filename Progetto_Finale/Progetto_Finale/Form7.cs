using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Finale
{
    public partial class Form_Schermata_Gioco_Difficile : Form
    {
        public Form_Schermata_Gioco_Difficile()
        {
            InitializeComponent();
        }
        int secondi = 60;
        private void Pausa_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Schiacciando il tasto pausa uscirai dalla partita e perderari il punteggio");
            secondi = 60;

            Form_Schermata_Pausa Pausa = new Form_Schermata_Pausa();
            Pausa.Show();
            this.Hide();
        }

       

        Random random = new Random();
        Random x = new Random();    //chiamo e inizializzo tutta la parte inerente al random per le generazioni degli scarafaggi  nelle coordinate e nelle tipologie
        Random y = new Random();
        int coordinataX = 0, coordinataY = 0;
        bool orizzontale = false;
        bool verticale = false;
        private void ScarafaggioNero_btn_Click(object sender, EventArgs e)
        {
            int TipoScarafaggio = random.Next(1, 4);
            switch (TipoScarafaggio)
            {
                case 1:
                    PuntoDiPartenza();
                    if (orizzontale == true)
                    {
                        //ScarafaggioNero_btn.Location = new Point(10, coordinataY);
                        ScarafaggioNero_btn.Left += coordinataX;
                        ScarafaggioNero_btn.Top += coordinataY;
                    }
                    if (verticale == true)
                    {
                        //ScarafaggioNero_btn.Location = new Point(coordinataX, 418);
                        ScarafaggioNero_btn.Left -= coordinataX;
                        ScarafaggioNero_btn.Top -= coordinataY;
                    }
                    break;

                case 2:
                    PuntoDiPartenza();
                    if (orizzontale == true)
                    {
                        //ScarafaggioVerde_btn.Location = new Point(10, coordinataY);
                        ScarafaggioVerde_btn.Visible = true;//Compare Scarafaggio verde
                        ScarafaggioVerde_btn.Left += coordinataX;
                        ScarafaggioVerde_btn.Top += coordinataY;
                    }
                    if (verticale == true)
                    {
                        //ScarafaggioVerde_btn.Location = new Point(coordinataX, 418);
                        ScarafaggioVerde_btn.Visible = true;//Compare Scarafaggio verde
                        ScarafaggioVerde_btn.Left -= coordinataX;
                        ScarafaggioVerde_btn.Top -= coordinataY;
                    }
                    ScarafaggioRosso_btn.Visible = false;
                    ScarafaggioNero_btn.Visible = false;//Sparisce scarafaggio nero
                    
                    break;

                case 3:
                    PuntoDiPartenza();
                    if (orizzontale == true)
                    {
                        //ScarafaggioRosso_btn.Location = new Point(10, coordinataY);
                        ScarafaggioRosso_btn.Visible = true;
                        ScarafaggioRosso_btn.Left += coordinataX;
                        ScarafaggioRosso_btn.Top += coordinataY;
                    }
                    if (verticale == true)
                    {
                        //ScarafaggioRosso_btn.Location = new Point(coordinataX, 418);
                        ScarafaggioRosso_btn.Visible = true;
                        ScarafaggioRosso_btn.Left -= coordinataX;
                        ScarafaggioRosso_btn.Top -= coordinataY;
                    }
                    ScarafaggioVerde_btn.Visible = false;
                    ScarafaggioNero_btn.Visible = false;
                    
                    break;
            }
            Program.ScarafaggiNeriSchiacciati = Program.ScarafaggiNeriSchiacciati + 1;
            Program.Punti = Program.Punti + 1;
            Punteggio_txt.Text = Program.Punti.ToString();
            orizzontale = false;
            verticale = false;
        }

        private void ScarafaggioVerde_btn_Click(object sender, EventArgs e)
        {
            int TipoScarafaggio = random.Next(1, 4);
            switch (TipoScarafaggio)
            {
                case 1:
                    PuntoDiPartenza();
                    ScarafaggioVerde_btn.Visible = false;
                    if (orizzontale == true)
                    {
                        ScarafaggioNero_btn.Visible = true;
                        ScarafaggioNero_btn.Left += coordinataX;
                        ScarafaggioNero_btn.Top += coordinataY;
                    }
                    if (verticale == true)
                    {
                        //ScarafaggioNero_btn.Location = new Point(coordinataX, 418);
                        ScarafaggioNero_btn.Visible = true;
                        ScarafaggioNero_btn.Left -= coordinataX;
                        ScarafaggioNero_btn.Top -= coordinataY;
                    }
                    ScarafaggioRosso_btn.Visible = false;
                    break;

                case 2:
                    PuntoDiPartenza();
                    if (orizzontale == true)
                    {
                        //ScarafaggioVerde_btn.Location = new Point(10, coordinataY);
                        ScarafaggioVerde_btn.Left += coordinataX;
                        ScarafaggioVerde_btn.Top += coordinataY;
                    }
                    if (verticale == true)
                    {
                        //ScarafaggioVerde_btn.Location = new Point(coordinataX, 418);
                        ScarafaggioVerde_btn.Left -= coordinataX;
                        ScarafaggioVerde_btn.Top -= coordinataY;
                    }
                    break;

                case 3:
                    PuntoDiPartenza();
                    ScarafaggioVerde_btn.Visible = false;
                    if (orizzontale == true)
                    {
                        //ScarafaggioRosso_btn.Location = new Point(10, coordinataY);
                        ScarafaggioRosso_btn.Visible = true;
                        ScarafaggioRosso_btn.Left += coordinataX;
                        ScarafaggioRosso_btn.Top += coordinataY;
                    }
                    if (verticale == true)
                    {
                        //ScarafaggioRosso_btn.Location = new Point(coordinataX, 418);
                        ScarafaggioRosso_btn.Visible = true;
                        ScarafaggioRosso_btn.Left -= coordinataX;
                        ScarafaggioRosso_btn.Top -= coordinataY;
                    }
                    ScarafaggioNero_btn.Visible = false;
                    break;
            }
            Program.ScarafaggiVerdiSchiacciati = Program.ScarafaggiVerdiSchiacciati + 1;
            Program.Punti = Program.Punti + 3;
            Punteggio_txt.Text = Program.Punti.ToString();
            orizzontale = false;
            verticale = false;
        }

        private void ScarafaggioRosso_btn_Click(object sender, EventArgs e)
        {
            int TipoScarafaggio = random.Next(1, 4);
            switch (TipoScarafaggio)
            {
                case 1:
                    PuntoDiPartenza();
                    ScarafaggioRosso_btn.Visible = false;
                    if (orizzontale == true)
                    {
                        //ScarafaggioNero_btn.Location = new Point(10, coordinataY);
                        ScarafaggioNero_btn.Visible = true;
                        ScarafaggioNero_btn.Left += coordinataX;
                        ScarafaggioNero_btn.Top += coordinataY;
                    }
                    if (verticale == true)
                    {
                        //ScarafaggioNero_btn.Location = new Point(coordinataX, 418);
                        ScarafaggioNero_btn.Visible = true;
                        ScarafaggioNero_btn.Left -= coordinataX;
                        ScarafaggioNero_btn.Top -= coordinataY;
                    }
                    ScarafaggioVerde_btn.Visible = false;
                    break;

                case 2:
                    PuntoDiPartenza();
                    ScarafaggioRosso_btn.Visible = false;
                    if (orizzontale == true)
                    {
                        //ScarafaggioVerde_btn.Location = new Point(10, coordinataY);
                        ScarafaggioVerde_btn.Visible = true;
                        ScarafaggioVerde_btn.Left += coordinataX;
                        ScarafaggioVerde_btn.Top += coordinataY;
                    }
                    if (verticale == true)
                    {
                        //ScarafaggioVerde_btn.Location = new Point(coordinataX, 418);
                        ScarafaggioVerde_btn.Visible = true;
                        ScarafaggioVerde_btn.Left -= coordinataX;
                        ScarafaggioVerde_btn.Top -= coordinataY;
                    }
                    ScarafaggioNero_btn.Visible = false;
                    break;

                case 3:
                    PuntoDiPartenza();
                    if (orizzontale == true)
                    {
                        //ScarafaggioRosso_btn.Location = new Point(10, coordinataY);
                        ScarafaggioRosso_btn.Left += coordinataX;
                        ScarafaggioRosso_btn.Top += coordinataY;
                    }
                    if (verticale == true)
                    {
                        //ScarafaggioRosso_btn.Location = new Point(coordinataX, 418);
                        ScarafaggioRosso_btn.Left -= coordinataX;
                        ScarafaggioRosso_btn.Top -= coordinataY;
                    }
                    break;
            }
            Program.ScarafaggiRossiSchiacciati = Program.ScarafaggiRossiSchiacciati + 1;
            Program.Punti = Program.Punti + 5;
            Punteggio_txt.Text = Program.Punti.ToString();
            orizzontale = false;
            verticale = false;
        }

        private void PuntoDiPartenza()
        {
            int xOy = random.Next(1, 3);
            switch(xOy)
            {
                case 1:             //Lo scarafaggio parte da sinistra a destra
                    orizzontale = true;
                    for (int i = 0; i < 5; i++)
                    {
                        coordinataX = x.Next(13, 1095);
                        coordinataY = y.Next(78, 516);
                    }
                    break;

                case 2:             //Lo scarafaggio parte dal basso verso l'alto
                    verticale = true;
                    for (int i = 0; i < 5; i++)
                    {
                        coordinataX = x.Next(13, 1095);
                        coordinataY = y.Next(78, 516);
                    }
                    break;
            }

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            secondi--;         //orologio        
            Timer_txt.Text = secondi.ToString();
            if (secondi == 0)
            {
                Program.GestioneClassificaDifficile[Program.Giocate - 1, 2] = Program.Punti.ToString();  //salvo nell'array i punti

                int j;
                int i;
                if (Program.GiocateDifficili > 1)            //ordino la classifica
                {
                    for (i = 0; i < Program.GiocateDifficili - 1; i++)
                    {
                        // Trova il minimo nel subarray da ordinare
                        int indice_min = i;
                        int primoElementoComparazione;
                        int secondoElementoComparazione;
                        for (j = i + 1; j < Program.GiocateDifficili; j++)
                        {
                            primoElementoComparazione = Convert.ToInt32(Program.GestioneClassificaDifficile[j, 2]);
                            secondoElementoComparazione = Convert.ToInt32(Program.GestioneClassificaDifficile[indice_min, 2]);
                            // Confronto per trovare un nuovo minimo
                            if (primoElementoComparazione < secondoElementoComparazione)
                            {
                                indice_min = j; // Salvo l'indice del nuovo minimo

                                // Scambia il minimo trovato con il primo elemento
                                Swap(indice_min, i);
                            }
                        }
                    }
                }

                Form_Schermata_Punteggio_Difficile Punteggio = new Form_Schermata_Punteggio_Difficile();
                Punteggio.Show();
                this.Close();
            }
        }
        private void Swap(int a, int b)     //swap di variabili
        {
            string tempPunteggio = Program.GestioneClassificaDifficile[a, 2];
            Program.GestioneClassificaDifficile[a, 2] = Program.GestioneClassificaDifficile[b, 2];
            Program.GestioneClassificaDifficile[b, 2] = tempPunteggio;
            string tempUsername = Program.GestioneClassificaDifficile[a, 1];
            Program.GestioneClassificaDifficile[a, 1] = Program.GestioneClassificaDifficile[b, 1];
            Program.GestioneClassificaDifficile[b, 1] = tempUsername;
        }
    }
}

