﻿using System;
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
    public partial class Recipe : Form
    {
        public Recipe()
        {
            InitializeComponent();
        }

        private void Recipe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface.AboutUs objA = new Interface.AboutUs();
            objA.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface.Main objA = new Interface.Main();
            objA.ShowDialog();
        }
    }
}
