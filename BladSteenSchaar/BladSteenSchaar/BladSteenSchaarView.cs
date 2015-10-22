using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BladSteenSchaar
{
    public partial class BladSteenSchaarView : UserControl
    {


        public BladSteenSchaarController bladSteenSchaarController;

        //lijst om meerdere KeuzeScore's te maken (in ons geval 2)
        public List<KeuzeScoreController> keuzescores = new List<KeuzeScoreController>();

       

        //constructor
        public BladSteenSchaarView(BladSteenSchaarController controller)
        {
            InitializeComponent();

            bladSteenSchaarController = controller;
        }




        public BladSteenSchaarView()
        {
            InitializeComponent();
        }



        private void BladSteenSchaarView_Load(object sender, EventArgs e)
        {

            messageLabel.Text = "Message";



            //het lager niveau 2 keer laten verschijnen met een bepaalde ruimte tussen



            //2 teerlingcontrollers aanmaken voor 2 KeuzeScore's te laten zien (in de constructor van de controller staat dat hij zelf ene view en model gaat aanmaken als hij wordt aangemaakt, dus die worden automatisch gecreëerd als je een controller aanmaakt.
            //2 keer door lus en elke keer een controller aanmaken
            for (int keuzeScoreNummer = 0; keuzeScoreNummer < 2; ++keuzeScoreNummer)
            {
                // Maak instantie aan van teerlingController
                KeuzeScoreController tijdelijkeKeuzeScore = new KeuzeScoreController();

                keuzescores.Add(tijdelijkeKeuzeScore);
            }



            //nu heb je de 2 Keuzescores aangemaakt maar om ze te laten zien -> getView nog doen
            for (int keuzeScoreNummer = 0; keuzeScoreNummer < 2; ++keuzeScoreNummer)
            {
                
                //controller.getView --> view die gelinkt is aan die controller
                KeuzeScoreView keuzeScoreView = keuzescores[keuzeScoreNummer].getView();

                // breedte van teerling ophalen en positie berekenen (0 * breedte teerling, ...)
                int horizontalPosition = keuzeScoreNummer * keuzeScoreView.Width;

                keuzeScoreView.Location = new System.Drawing.Point(horizontalPosition, 0);

                //zodat je kunt klikken in keuzescore
                Controls.Add(keuzeScoreView);


            }




        }




        private void messageLabel_Click(object sender, EventArgs e)
        {

        }




        private void titelSpelerLabel_Click(object sender, EventArgs e)
        {

        }




        private void titelComputerLabel_Click(object sender, EventArgs e)
        {

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void goButton_Click(object sender, EventArgs e)
        {


            //de waardes voor in de Keuze variabele in het model van de KeuzeScores ophalen uit de dropdown en de computerkeuze methode

            BladSteenSchaarController controller = new BladSteenSchaarController();

            keuzescores[0].model.Keuze = dropdown.SelectedItem.ToString();

            controller.Computerkeuze();

            keuzescores[1].model.Keuze = controller.bladSteenSchaarModel.ComputerKeuze;
            

            //om labels te kunnen vullen --> in de view van de KeuzeScores geraken en daar de labels aanspreken
            KeuzeScoreView viewSpeler = keuzescores[0].getView();

            KeuzeScoreView viewComputer = keuzescores[1].getView();

            viewSpeler.UpdateUI();

            viewComputer.UpdateUI();




        }




    }
}
