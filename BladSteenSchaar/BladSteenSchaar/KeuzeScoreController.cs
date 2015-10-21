using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladSteenSchaar
{
    public class KeuzeScoreController
    {

        KeuzeScoreView view;
        public KeuzeScoreModel model;


        //constructor
        public KeuzeScoreController ()
        {

            // Controller is degene die alles regelt, begint met het aanmaken van een model en view en regelt daarna alles via methodes
            view = new KeuzeScoreView(this); //constructor van de view --> parameter een controller 
            model = new KeuzeScoreModel();

        }


        //om bv in de laag erboven de view te kunnen laten zien 
        public KeuzeScoreView getView()
        {

            return view;

        }














    }
}
