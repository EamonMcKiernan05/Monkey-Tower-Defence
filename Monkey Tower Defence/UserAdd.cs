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
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }

        private void UserAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
