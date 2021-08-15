using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Finale
{
    public partial class Form_Schermata_Punteggio_Difficile : Form
    {
        public Form_Schermata_Punteggio_Difficile()
        {
            InitializeComponent();
        }

        private void Form_Schermata_Punteggio_Difficile_Load(object sender, EventArgs e)
        {
            PunteggioFinale_txt.Text = Program.Punti.ToString();                                    //Scrivo i vari punteggi
            ScarafaggiNeriSchiacciati_txt.Text = Program.ScarafaggiNeriSchiacciati.ToString();
            ScarafaggiVerdiSchiacciati_txt.Text = Program.ScarafaggiVerdiSchiacciati.ToString();
            ScarafaggiRossiSchiacciati_txt.Text = Program.ScarafaggiRossiSchiacciati.ToString();

            string FileSalvataggio = AppDomain.CurrentDomain.BaseDirectory + "SalvataggioDifficile" +".txt";
            StreamWriter streamwriter = new StreamWriter(FileSalvataggio, true);//metto true in modo che non sovrascriva le stringhe nel file.
            streamwriter.WriteLine("{0}, {1}, {2}", Program.GestioneClassifica[Program.Giocate - 1, 0], Program.GestioneClassifica[Program.Giocate - 1, 1], Program.GestioneClassifica[Program.Giocate - 1, 2]);
            streamwriter.Close();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            RipristinoVariabili();

            Form_Schermata_iniziale Home = new Form_Schermata_iniziale();
            Home.Show();
            this.Hide();
        }

        private void Classifica_btn_Click(object sender, EventArgs e)
        {
            RipristinoVariabili();

            Form_Schermata_Classifica_Difficile Classifica = new Form_Schermata_Classifica_Difficile();
            Classifica.Show();
            this.Hide();
        }
        private void RipristinoVariabili()
        {
            Program.Punti = 0;
            Program.NomePlayer = "";
            Program.ScarafaggiNeriSchiacciati = 0;
            Program.ScarafaggiVerdiSchiacciati = 0;
            Program.ScarafaggiRossiSchiacciati = 0;
        }
    }
}
