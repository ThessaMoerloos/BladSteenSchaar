using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladSteenSchaar
{
    public class BladSteenSchaarController
    {

        public BladSteenSchaarModel bladSteenSchaarModel;
        public BladSteenSchaarView bladSteenSchaarView;
        static int seed = 0;


        public BladSteenSchaarController()
        {
            //constructor
            bladSteenSchaarView = new BladSteenSchaarView(this);
            bladSteenSchaarModel = new BladSteenSchaarModel();

        }




        public BladSteenSchaarView getView()
        {

            return bladSteenSchaarView;

        }


        public void Computerkeuze()
        {

            string computerkeuze = "";
            // random object maken
            Random random = new Random(seed);

            //getal berekenen tussen 0 en 2 (0, 1 of 2)
            int keuzeNummer = random.Next(0, 3);


            if (keuzeNummer == 0)
            {
                computerkeuze = "Blad";
             }

            if (keuzeNummer == 1)
            {
                computerkeuze = "Steen";
            }

            if (keuzeNummer == 2)
            {
                computerkeuze = "Schaar";
            }


                                                    //string " "
            bladSteenSchaarModel.ComputerKeuze = computerkeuze;

            seed++;

            

        }



    }
}
