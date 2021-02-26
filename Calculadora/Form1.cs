using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }


        Aritmetica.Suma sm = new Aritmetica.Suma();
        Aritmetica.Resta rt = new Aritmetica.Resta();
        Aritmetica.Multiplicacion mtp = new Aritmetica.Multiplicacion();
        Aritmetica.Division dvs = new Aritmetica.Division();


        private void btnN0_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += "9";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtDataScreen.Text);
            txtDataScreen.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtDataScreen.Text);
            txtDataScreen.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtDataScreen.Text);
            txtDataScreen.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtDataScreen.Text);
            txtDataScreen.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDataScreen.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text = txtDataScreen.Text.Substring(0, txtDataScreen.Text.Length - 1);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            double sum;
            double res;
            double mult;
            double div;

            segundo = double.Parse(txtDataScreen.Text);

            switch (operador)
            {
                case "+":
                    txtDataScreen.Clear();
                    sum = sm.Sumar(primero, segundo);
                    txtDataScreen.Text += sum.ToString();
                    break;

                case "-":
                    txtDataScreen.Clear();
                    res = rt.Restar(primero, segundo);
                    txtDataScreen.Text += res.ToString();
                    break;

                case "*":
                    txtDataScreen.Clear();
                    mult = mtp.Multiplicar(primero, segundo);
                    txtDataScreen.Text += mult.ToString();
                    break;

                case "/":
                    txtDataScreen.Clear();
                    div = dvs.Dividir(primero, segundo);
                    txtDataScreen.Text += div.ToString();
                    break;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtDataScreen.Text += ".";
        }
    }
}
