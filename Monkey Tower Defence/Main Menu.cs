using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Monkey_Tower_Defence
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // start button
        {
            Game_Map form = new Game_Map();
            form.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e) // exit button
        {
            Application.Exit();
        }

        private void lblHighScore_Click(object sender, EventArgs e)
        {

        }

        private void lblHighScore_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnhighscore_Click(object sender, EventArgs e)
        {
            using (StreamReader currentfile = new StreamReader("highscore.txt"))
            {
                lblhighscore.Text = "High Score: " + currentfile.ReadLine();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
