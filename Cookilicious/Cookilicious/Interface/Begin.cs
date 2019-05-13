using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookilicious
{
    public partial class Begin : Form
    {

        public Begin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Interface.SignIn obj = new Interface.SignIn();
            obj.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface.Login objUI = new Interface.Login();
            objUI.ShowDialog();
            Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interface.AboutUs objA = new Interface.AboutUs();
            objA.ShowDialog();
            Close();
        }
    }
}
