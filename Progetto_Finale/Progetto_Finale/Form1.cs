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


//Schermata principale
namespace Progetto_Finale
{
    public partial class Form_Schermata_iniziale : Form
    {
        public Form_Schermata_iniziale()
        {
            InitializeComponent();
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            Program.Giocate = Program.Giocate + 1;
            Program.NomePlayer = Convert.ToString(NomePlayer_txt.Text);
            Program.GestioneClassifica[Program.Giocate-1, 1] = Convert.ToString(NomePlayer_txt.Text); //salvo nell'array il nome del player

            if (Program.Giocate == 1)
            {
                MessageBox.Show("Regole del gioco: \nSchiaccia più scarafaggi possibili in un minuto, ecco i seguenti punteggi:\n--> Scarafaggio Nero 1 pt;\n--> Scarafaggio Verde 3 pt;\n--> Scarafaggio Rosso 5 pt.");
            }

            if (NomePlayer_txt.Text == "")      //controllo se non viene inserito il nome
            {
                MessageBox.Show("Inserisci il nome del player");
            }
            else
            {
                Form_Modalità_Di_Gioco Mood = new Form_Modalità_Di_Gioco();
                Mood.Show();
                this.Hide();
            }
        }
    }
}
