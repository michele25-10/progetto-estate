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

                Form_Schermata_Punteggio_Difficile Punteggio = new Form_Schermata_Punteggio_Difficile();
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
    }
}

