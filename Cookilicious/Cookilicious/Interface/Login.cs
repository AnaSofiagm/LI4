using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookilicious.Interface
{
    public partial class Login : Form
    {
        /// <summary>
        /// Occurs when the login button is clicked.
        /// </summary>
        public event EventHandler LoginButtonClick
        {
            add { button2.Click += value; }
            remove { button2.Click -= value; }
        }

        /// <summary>
        /// Occurs when the cancel button is clicked.
        /// </summary>
        public event EventHandler ExitButtonClick
        {
            add { button1.Click += value; }
            remove { button1.Click -= value; }
        }

       

        /// <summary>
        /// Gets or sets the inputted address.
        /// </summary>
        public string Email
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        
        /// <summary>
        /// Gets or sets the inputted client name.
        /// </summary>
        public string Password
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        private bool loggingIn;
        /// <summary>
        /// Gets or sets whether the client is logging in or not.
        /// </summary>
        public bool LoggingIn
        {
            get { return loggingIn; }
            set
            {
                loggingIn = value;

                if (value)
                {
                    button1.Enabled = true;
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    button1.Enabled = false;
                }
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
