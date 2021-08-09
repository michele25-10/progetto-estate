using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Finale
{
    static class Program
    {
        public static int Giocate;
        public static int Punti; //variabili globali
        public static string NomePlayer;
        public static int ScarafaggiNeriSchiacciati, ScarafaggiVerdiSchiacciati, ScarafaggiRossiSchiacciati;
        public static string[,] GestioneClassifica = new string[50, 3];        

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Schermata_iniziale());
        }
    }
}
