using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladSteenSchaar
{
    public class KeuzeScoreModel
    {

        private int score = 0;
        private string keuze;
        /*private string achtergrondkleur;*/

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




        /*public string Achtergrondkleur
        {
            get
            {
                return achtergrondkleur;
            }
            set
            {
                achtergrondkleur = value;
            }
        }*/




    }
}
