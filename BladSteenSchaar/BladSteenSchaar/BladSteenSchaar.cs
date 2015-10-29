using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BladSteenSchaar
{
    public partial class BladSteenSchaar : Form
    {


        public BladSteenSchaar()
        {

            InitializeComponent();
            this.Text = "Blad steen schaar";

        }



        private void BladSteenSchaar_Load(object sender, EventArgs e)
        {

            BladSteenSchaarController bladSteenSchaarController = new BladSteenSchaarController();

            BladSteenSchaarView bladSteenSchaarView = bladSteenSchaarController.getView();

            Controls.Add(bladSteenSchaarView);

        }
    }
}
