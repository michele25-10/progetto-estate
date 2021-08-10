﻿using System;
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
    public partial class Form_Schermata_Classifica_Difficile : Form
    {
        public Form_Schermata_Classifica_Difficile()
        {
            InitializeComponent();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            {
                Form_Schermata_iniziale Home = new Form_Schermata_iniziale();
                Home.Show();
                this.Hide();
            }
        }

        int CreazioneClassifica = 0;
        private void Classifica_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CreazioneClassifica = CreazioneClassifica + 1;
            if (CreazioneClassifica == 1)
            {
                Classifica_dgv.Rows.Add();
                Classifica_dgv.Rows.Add(); //creo le 3 righe
                Classifica_dgv.Rows[0].Cells[0].Value = "1";
                Classifica_dgv.Rows[1].Cells[0].Value = "2";        //scrivo la classifica
                Classifica_dgv.Rows[2].Cells[0].Value = "3";
            }

            if (Program.Giocate == 1)       //se c'è stato solamente una partita... scrivo solo nella prima riga
            {
                Classifica_dgv.Rows[0].Cells[1].Value = Program.GestioneClassifica[Program.Giocate - 1, 1];  //dato che l'array è ordinato in maniera crescente scrivo gli ultimi livelli dell'array
                Classifica_dgv.Rows[0].Cells[2].Value = Program.GestioneClassifica[Program.Giocate - 1, 2];
            }

            if (Program.Giocate == 2)        //se sono state fatte due partita... scrivo solo nelle due righe
            {
                Classifica_dgv.Rows[0].Cells[1].Value = Program.GestioneClassifica[Program.Giocate - 1, 1];  //dato che l'array è ordinato in maniera crescente scrivo gli ultimi livelli dell'array
                Classifica_dgv.Rows[0].Cells[2].Value = Program.GestioneClassifica[Program.Giocate - 1, 2];
                Classifica_dgv.Rows[1].Cells[1].Value = Program.GestioneClassifica[Program.Giocate - 2, 1];
                Classifica_dgv.Rows[1].Cells[2].Value = Program.GestioneClassifica[Program.Giocate - 2, 2];
            }

            if (Program.Giocate >= 3)       //se sono state fatte più di tre partita... scrivo solo nelle 3 righe
            {
                Classifica_dgv.Rows[0].Cells[1].Value = Program.GestioneClassifica[Program.Giocate - 1, 1];  //dato che l'array è ordinato in maniera crescente scrivo gli ultimi livelli dell'array
                Classifica_dgv.Rows[0].Cells[2].Value = Program.GestioneClassifica[Program.Giocate - 1, 2];
                Classifica_dgv.Rows[1].Cells[1].Value = Program.GestioneClassifica[Program.Giocate - 2, 1];
                Classifica_dgv.Rows[1].Cells[2].Value = Program.GestioneClassifica[Program.Giocate - 2, 2];
                Classifica_dgv.Rows[2].Cells[1].Value = Program.GestioneClassifica[Program.Giocate - 3, 1];
                Classifica_dgv.Rows[2].Cells[2].Value = Program.GestioneClassifica[Program.Giocate - 3, 2];
            }
        }
    }
}