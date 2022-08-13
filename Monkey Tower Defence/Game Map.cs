using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monkey_Tower_Defence
{
    public partial class Game_Map : Form
    {
        public Game_Map()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e) //coins counter
        {

        }

        int coins = 0;
        private void scoretimer_Tick(object sender, EventArgs e)
        {
            lblCoins.Text = "Coins: "  + coins;
            coins++;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int ADCount = 1;
        private void btnAD_Click(object sender, EventArgs e)
        {
            if (coins >= 50)
            {
                lblADCount.Text = ADCount.ToString();
                coins = coins - 50;
                ADCount++;
            }
            else
            {
                
            }
        }

        private void btnCannon_Click(object sender, EventArgs e)
        {
            if (coins >= 125)
            {
                lblCannonCount.Text = ADCount.ToString();
                coins = coins - 125;
                ADCount++;
            }
            else
            {

            }
        }

        private void btnXbow_Click(object sender, EventArgs e)
        {
            if (coins >= 275)
            {
                lblXBowCount.Text = ADCount.ToString();
                coins = coins - 275;
                ADCount++;
            }
            else
            {

            }
        }
    }  
}
