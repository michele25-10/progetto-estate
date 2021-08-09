using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Schermata di pausa

namespace Progetto_Finale
{
    public partial class Form_Schermata_Pausa : Form
    {
        public Form_Schermata_Pausa()
        {
            InitializeComponent();
        }

        private void Ricomincia_btn_Click(object sender, EventArgs e)
        {
            RipristinoVariabili();  //Chiamo la funzione per ripristinare le variabili

            Form_Schermata_Gioco Gioco = new Form_Schermata_Gioco();
            Gioco.Show();
            this.Hide();
        }
        private void Home_btn_Click(object sender, EventArgs e)
        {
            RipristinoVariabili();

            Form_Schermata_iniziale Inizio = new Form_Schermata_iniziale();
            Inizio.Show();
            this.Hide();
        }

        private void Classifica_btn_Click(object sender, EventArgs e)
        {
            RipristinoVariabili();

            Form_Schermata_Classifica Classifica = new Form_Schermata_Classifica();
            Classifica.Show();
            this.Hide();
        }
        private void RipristinoVariabili()
        {
            Program.NomePlayer = "";
            Program.Punti = 0;
            Program.ScarafaggiNeriSchiacciati = 0;
            Program.ScarafaggiVerdiSchiacciati = 0;
            Program.ScarafaggiRossiSchiacciati = 0;
        }
    }
}
