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
    public partial class Form_Modalità_Di_Gioco : Form
    {
        public Form_Modalità_Di_Gioco()
        {
            InitializeComponent();
        }

        private void Facile_btn_Click(object sender, EventArgs e)
        {
            Program.Giocate = Program.Giocate + 1;
            Program.GestioneClassifica[Program.Giocate - 1, 1] = Program.NomePlayer; //salvo nell'array il nome del player
            Program.NomePlayer = "";

            Form_Schermata_Gioco GiocoFacile = new Form_Schermata_Gioco();
            GiocoFacile.Show();
            this.Hide();
        }

        private void Difficile_btn_Click(object sender, EventArgs e)
        {
            Program.GiocateDifficili = Program.GiocateDifficili + 1;
            Program.GestioneClassificaDifficile[Program.GiocateDifficili - 1, 1] = Program.NomePlayer;
            Program.NomePlayer = "";

            Form_Schermata_Gioco_Difficile GiocoDifficile = new Form_Schermata_Gioco_Difficile();
            GiocoDifficile.Show();
            this.Hide();
        }
    }
}
