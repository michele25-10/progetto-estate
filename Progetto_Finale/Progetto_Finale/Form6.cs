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
            Form_Schermata_Gioco GiocoFacile = new Form_Schermata_Gioco();
            GiocoFacile.Show();
            this.Hide();
        }

        private void Difficile_btn_Click(object sender, EventArgs e)
        {
            Form_Schermata_Gioco_Difficile GiocoDifficile = new Form_Schermata_Gioco_Difficile();
            GiocoDifficile.Show();
            this.Hide();
        }
    }
}
