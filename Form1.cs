﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Atividade1
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

       
        private void button20_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tbResultado.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                tbResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                tbResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTI")
            {
                tbResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                tbResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
                tbResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão!");
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
                tbResultado.Text = "";
                operacao = "MULTI";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação!");
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
                tbResultado.Text = "";
                operacao = "DIVI";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
                tbResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma!");
            }
            
        }
    }
}
