using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladSteenSchaar
{
    public class KeuzeScoreModel
    {

        private int score = 0;
        private string keuze;
        private Color achtergrondkleur;


        public KeuzeScoreModel()
        {

        }


        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }




        public string Keuze
        {
            get
            {
                return keuze;
            }
            set
            {
                keuze = value;
            }
        }




        
        public Color Achtergrondkleur
        {
            get
            {
                return achtergrondkleur;
            }
            set
            {
                achtergrondkleur = value;
            }
        }



    }
}
