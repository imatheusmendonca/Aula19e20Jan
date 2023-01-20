using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto19Janeiro
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ce_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(btresu.Text, CultureInfo.InvariantCulture);

            btresu.Text = "";
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt7_Click(object sender, EventArgs e)
        {
            btresu.Text=btresu.Text+"7";
            
        }

        private void tbresu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            btresu.Text = btresu.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            btresu.Text = btresu.Text + "9";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            btresu.Text = btresu.Text + "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            btresu.Text = btresu.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            btresu.Text = btresu.Text + "6";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            btresu.Text = btresu.Text + "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            btresu.Text = btresu.Text + "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            btresu.Text = btresu.Text + "3";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            btresu.Text = btresu.Text + "0";
        }

        private void mais_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(btresu.Text, CultureInfo.InvariantCulture);

            btresu.Text = "";
            operacao = "soma";
            label1.Text = "+";
        }

        private void menos_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(btresu.Text, CultureInfo.InvariantCulture);

            btresu.Text = "";
            operacao = "subtracao";
            label1.Text = "-";
        }

        private void vezes_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(btresu.Text, CultureInfo.InvariantCulture);

            btresu.Text = "";
            operacao = "multiplicacao";
            label1.Text = "x";
        }

        private void barra_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(btresu.Text, CultureInfo.InvariantCulture);

            btresu.Text = "";
            operacao = "divisao";
            label1.Text = "/";
        }

        private void c_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(btresu.Text, CultureInfo.InvariantCulture);

            btresu.Text = "";
            valor1 = 0;
            valor2 = 0;
             
            
        
        }

        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(btresu.Text, CultureInfo.InvariantCulture);

            if (operacao == "soma")
            {
                btresu.Text = Convert.ToString(valor1 + valor2);
         
            }
            if (operacao == "subtracao")
            {
                btresu.Text = Convert.ToString(valor1 - valor2);

            }
            if (operacao == "multiplicacao")
            {
                btresu.Text = Convert.ToString(valor1 * valor2);

            }
            if (operacao == "divisao")
            {
                btresu.Text = Convert.ToString(valor1 / valor2);

            }
        }
        
    }
}

