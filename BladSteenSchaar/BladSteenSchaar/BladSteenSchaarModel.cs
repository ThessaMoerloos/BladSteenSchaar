using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladSteenSchaar
{

    public class BladSteenSchaarModel
    {

        private string computerKeuze;
        private string dropdownKeuze;

        public string DropdownKeuze
        {
            get
            {
                return dropdownKeuze;
            }
            set
            {
                dropdownKeuze = value;
            }
        }


        public string ComputerKeuze
        {
            get
            {
                return computerKeuze;
            }
            set
            {
                computerKeuze = value;
            }
        }


       


    }
}
