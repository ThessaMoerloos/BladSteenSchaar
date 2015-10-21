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


        public string Computerkeuze()
        {

            string computerkeuze = "";

            return computerkeuze;

        }



    }
}
