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
    public partial class Form1 : Form
    {   // criando variaveis
        string operacao, Soma, Sub, Div, Vezes;
        double resultado;
        // botões
        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += 0;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Clear();
                txt_Resultado.Text += 1;
            }
            else
            {
                txt_Resultado.Text += 1;
            }

        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Clear();
                txt_Resultado.Text += 2;
            }
            else
            {
                txt_Resultado.Text += 2;
            }
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Clear();
                txt_Resultado.Text += 3;
            }
            else
            {
                txt_Resultado.Text += 3;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Clear();
                txt_Resultado.Text += 4;
            }
            else
            {
                txt_Resultado.Text += 4;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Clear();
                txt_Resultado.Text += 5;
            }
            else
            {
                txt_Resultado.Text += 5;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Clear();
                txt_Resultado.Text += 6;
            }
            else
            {
                txt_Resultado.Text += 6;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Clear();
                txt_Resultado.Text += 7;
            }
            else
            {
                txt_Resultado.Text += 7;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Clear();
                txt_Resultado.Text += 8;
            }
            else
            {
                txt_Resultado.Text += 8;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Clear();
                txt_Resultado.Text += 9;
            }
            else
            {
                txt_Resultado.Text += 9;
            }
        }

        public Form1()
        {
            InitializeComponent();

        }
        // criando metodo operação
        private void Operacao(double v)
        {   // criadando variavel
            double valor;

            if (operacao == Soma)
            {
                valor = resultado + v;
                resultado = valor;
                lb_Resultado.Text = valor.ToString();
            }
        }
        // botao de soma
        private void btn_Soma_Click(object sender, EventArgs e)
        {
            Operacao(double.Parse(txt_Resultado.Text));
            txt_Resultado.Clear();
            txt_Resultado.Focus();
        }
        // botao Resultado
        private void btn_Resultado_Click(object sender, EventArgs e)
        {   // criando variaveis
            double n1, n2 , resultado1;
            // convertendo as variaveis
            n1 = Convert.ToDouble(lb_Resultado.Text);
            n2 = double.Parse(txt_Resultado.Text);

            // verificando se operacao selecionado é soma
            if(operacao== Soma)
            {
                resultado1 = n1 + n2;
                txt_Resultado.Text = resultado1.ToString();
                lb_Resultado.Text = resultado1.ToString();
            }
           
        }

        //botão Limpar Tudo
        private void btn_LimparTudo_Click(object sender, EventArgs e)
        {
            txt_Resultado.Clear();
            txt_Resultado.Clear();
        }
    }
}
