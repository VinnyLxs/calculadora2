using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }//0

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }//1

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }//2

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }//3

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }//4

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }//5

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }//6

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }//7

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }//8

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }//9

        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + ".";
        }//.
    }
}
