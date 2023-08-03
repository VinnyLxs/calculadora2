using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private void button18_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);



            if (operacao = "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else

            if (operacao = "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else

            if (operacao = "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
            if (operacao = "Raiz")

            {
                txtResultado.Text = Convert.ToString(valor1 ^ valor2);
            }
            else
            {

            }
        }//=
    }
}
