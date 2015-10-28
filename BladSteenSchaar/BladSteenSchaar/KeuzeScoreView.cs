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
    public partial class KeuzeScoreView : UserControl
    {

        private KeuzeScoreController controller;

        public KeuzeScoreView(KeuzeScoreController c)
        {

            InitializeComponent();

            controller = c;

        }

        private void KeuzeScoreView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void labelScoreWaarde_Click(object sender, EventArgs e)
        {

        }


        public void UpdateUI()
        {

            //presenter is enige die met view kan praten. Als je dit in controller maakt gebeurt er niks met de view.
            string keuze = controller.model.Keuze;
            keuzeLabel.Text = keuze;

            int score = controller.model.Score;
            scoreWaardeLabel.Text = score.ToString();

            Color kleur = controller.model.Achtergrondkleur;
            keuzeLabel.BackColor = kleur;

        }

        
    }
}
