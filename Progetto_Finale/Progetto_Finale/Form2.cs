using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Schermata di gioco

namespace Progetto_Finale
{
    public partial class Form_Schermata_Gioco : Form
    {

        public Form_Schermata_Gioco()
        {
            InitializeComponent();
        }
        private void Pausa_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Schiacciando il tasto pausa uscirai dalla partita e perderari il punteggio");
            secondi = 60;

            Form_Schermata_Pausa Pausa = new Form_Schermata_Pausa();
            Pausa.Show();
            this.Hide();
        }

        private void Timer_txt_Click(object sender, EventArgs e)
        {

        }

        Random random = new Random();
        Random x = new Random();    //chiamo e inizializzo tutta la parte inerente al random per le generazioni degli scarafaggi  nelle coordinate e nelle tipologie
        Random y = new Random();
        int coordinataX = 0, coordinataY = 0;


        private void ScarafaggioNero_btn_Click(object sender, EventArgs e)
        {
            int TipoScarafaggio = random.Next(1, 4);
            switch (TipoScarafaggio)
            {
                case 1:
                    CoordinateRandom();
                    ScarafaggioNero_btn.Location = new Point(coordinataX, coordinataY);
                    break;

                case 2:
                    CoordinateRandom();
                    ScarafaggioVerde_btn.Location = new Point(coordinataX, coordinataY);
                    ScarafaggioNero_btn.Visible = false;//Sparisce scarafaggio nero
                    ScarafaggioVerde_btn.Visible = true;//Compare Scarafaggio verde
                    break;

                case 3:
                    CoordinateRandom();
                    ScarafaggioRosso_btn.Location = new Point(coordinataX, coordinataY);
                    ScarafaggioNero_btn.Visible = false;
                    ScarafaggioRosso_btn.Visible = true;
                    break;
            }
            Program.ScarafaggiNeriSchiacciati = Program.ScarafaggiNeriSchiacciati + 1;
            Program.Punti = Program.Punti + 1;
            Punteggio_txt.Text = Program.Punti.ToString();
        }
        private void ScarafaggioVerde_btn_Click(object sender, EventArgs e)
        {
            int TipoScarafaggio = random.Next(1, 4);
            switch (TipoScarafaggio)
            {
                case 1:
                    CoordinateRandom();
                    ScarafaggioNero_btn.Location = new Point(coordinataX, coordinataY);
                    ScarafaggioVerde_btn.Visible = false;
                    ScarafaggioNero_btn.Visible = true;
                    break;

                case 2:
                    CoordinateRandom();
                    ScarafaggioVerde_btn.Location = new Point(coordinataX, coordinataY);
                    break;

                case 3:
                    CoordinateRandom();
                    ScarafaggioRosso_btn.Location = new Point(coordinataX, coordinataY);
                    ScarafaggioVerde_btn.Visible = false;
                    ScarafaggioRosso_btn.Visible = true;
                    break;
            }
            Program.ScarafaggiVerdiSchiacciati = Program.ScarafaggiVerdiSchiacciati + 1;
            Program.Punti = Program.Punti + 3;
            Punteggio_txt.Text = Program.Punti.ToString();
        }

        private void ScarafaggioRosso_btn_Click(object sender, EventArgs e)
        {
            int TipoScarafaggio = random.Next(1, 4);
            switch (TipoScarafaggio)
            {
                case 1:
                    CoordinateRandom();
                    ScarafaggioNero_btn.Location = new Point(coordinataX, coordinataY);
                    ScarafaggioRosso_btn.Visible = false;
                    ScarafaggioNero_btn.Visible = true;
                    break;

                case 2:
                    CoordinateRandom();
                    ScarafaggioVerde_btn.Location = new Point(coordinataX, coordinataY);
                    ScarafaggioRosso_btn.Visible = false;
                    ScarafaggioVerde_btn.Visible = true;
                    break;

                case 3:
                    CoordinateRandom();
                    ScarafaggioRosso_btn.Location = new Point(coordinataX, coordinataY);
                    break;
            }
            Program.ScarafaggiRossiSchiacciati = Program.ScarafaggiRossiSchiacciati + 1;
            Program.Punti = Program.Punti + 5;
            Punteggio_txt.Text = Program.Punti.ToString();
        }
        private void CoordinateRandom()     //generate le coordinate
        {
            for (int i = 0; i < 5; i++)
            {
                coordinataX = x.Next(9, 576);
            }
            for (int i = 0; i < 5; i++)
            {
                coordinataY = y.Next(50, 403);
            }
        }

        int secondi = 60;

        private void timer_Tick(object sender, EventArgs e)
        {
            secondi--;         //orologio        
            Timer_txt.Text = secondi.ToString();
            if (secondi == 0)
            {
                Program.GestioneClassifica[Program.Giocate - 1, 2] = Program.Punti.ToString();  //salvo nell'array i punti

                int j;
                int i;
                if (Program.Giocate > 1)            //ordino la classifica
                {
                    for (i = 0; i < Program.Giocate - 1; i++)
                    {
                        // Trova il minimo nel subarray da ordinare
                        int indice_min = i;
                        int primoElementoComparazione;
                        int secondoElementoComparazione;
                        for (j = i + 1; j < Program.Giocate; j++)
                        {
                            primoElementoComparazione = Convert.ToInt32(Program.GestioneClassifica[j, 2]);
                            secondoElementoComparazione = Convert.ToInt32(Program.GestioneClassifica[indice_min, 2]);
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

                j = 0;
                i = 0;

                Form_Schermata_Punteggio Punteggio = new Form_Schermata_Punteggio();
                Punteggio.Show();
                this.Close();
            }
        }
        private void Swap(int a, int b)     //swap di variabili
        {
            string tempPunteggio = Program.GestioneClassifica[a, 2];
            Program.GestioneClassifica[a, 2] = Program.GestioneClassifica[b, 2];
            Program.GestioneClassifica[b, 2] = tempPunteggio;
            string tempUsername = Program.GestioneClassifica[a, 1];
            Program.GestioneClassifica[a, 1] = Program.GestioneClassifica[b, 1];
            Program.GestioneClassifica[b, 1] = tempUsername;
        }
        private void Form_Schermata_Gioco_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
