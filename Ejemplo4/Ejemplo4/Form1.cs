﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x, N, suma = 0;
            listBox1.Items.Clear();
            N = int.Parse(txtN.Text);
            for(x = 1; x <= N; x++)
            {
                suma = suma + x;
                if (checkBox1.Checked == true)
                {
                    listBox1.Items.Add(" sumando: " + x + " Suma parcial: " + suma);
                }
            }
            listBox1.Items.Add("La suma TOTAL es: " + suma);
        }
    }
}
