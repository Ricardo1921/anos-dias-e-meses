using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora14
{
    public partial class Form1 : Form
    {

        double valor1;
        double valor2;
        double resultado;
        double memoria;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Clicar(object sender, EventArgs e)
        {
            valor2 = double.Parse(label1.Text);
            switch (operador)
            {
                case "+":
                    resultado = valor1 + valor2;
                    label1.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = valor1 - valor2;
                    label1.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = valor1 * valor2;
                    label1.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = valor1 / valor2;
                    label1.Text = resultado.ToString();
                    break;

                case ".":
                    if (!label1.Text.Contains(".")) label1.Text += ".";
                    break;


            }

        }
        private void button22_Click(object sender, EventArgs e)
        {
            operador = "-";
            valor1 = double.Parse(label1.Text);
            label1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ",";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            operador = "+";
            valor1 = double.Parse(label1.Text);
            label1.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            operador = "*";
            valor1 = double.Parse(label1.Text);
            label1.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            operador = "/";
            valor1 = double.Parse(label1.Text);
            label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(label1.Text);
            resultado = valor1;
            label1.Text = Math.Sqrt(valor1).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operador = "%";
            valor2 = double.Parse(label1.Text);
            resultado = valor1 + valor2;
            label1.Text = Convert.ToString((valor1 * valor2) / 100);
            label1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            memoria = memoria - Convert.ToDouble(label1.Text);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            memoria = memoria + Convert.ToDouble(label1.Text);

        }
        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            memoria = Convert.ToDouble(label1.Text);
        }
    }
}
