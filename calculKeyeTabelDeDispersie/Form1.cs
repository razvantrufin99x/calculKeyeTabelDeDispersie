using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculKeyeTabelDeDispersie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int M = 13;
        public bool DEBUG = false;
        int f (string key)
        {
            int i, suma;
            char c=' ';
            suma = 0;
            for (i = 0; i < key.Length; i++)
                c = char.Parse( key.Substring(i,1));
           suma = suma + (c + i);

           if (DEBUG == false)
           { return suma % M; }
           else
           { return suma;}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = f(textBox1.Text);
            textBox2.Text = i.ToString();
        }
    }
}
