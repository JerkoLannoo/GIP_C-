﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form2 : Form
    {
       // public  string code { get; set; }
        public Form2()
        {
            InitializeComponent();
     
        }


         private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onload(object sender, EventArgs e)
        {
          //  label1.Text = code;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
   
}
