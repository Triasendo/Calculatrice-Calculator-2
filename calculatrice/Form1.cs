using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class Form1 : Form
    {
        // int input;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //  showing the outpiut , in the words show the result for the secon
            Resul.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text) * 1).ToString();
           


        }

        private void button2_Click(object sender, EventArgs e)
        { 
            //  showing the outpiut , in the words show the result for the secon
           Resul.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text) * 12).ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)

        {   // after all  the result it will erase all the information 
            Resul.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
