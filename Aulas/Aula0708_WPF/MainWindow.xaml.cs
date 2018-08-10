using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aula0708_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool flagVirgula = false;
        char opr;
        bool flagValorPreenchido = false;
        double valor1 = 0;
        double valor2 = 0;
        double resultado = 0;
        double? valorMemoria = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        public string digitaVerificaZero(string valor, int num)
        {
            if (valor.Equals("Err"))
            {
                return valor1.ToString();
            }
            if(valor.Equals("0"))
            {
                valor = num.ToString();
            }
            else
            {
                valor += num;
            }
            return valor;
        }

        public void salvaValor1(char opr)
        {
            if (!flagValorPreenchido)
            {
                valor1 = double.Parse(txtboxNumeros.Text);
                txtboxNumeros.Text = 0.ToString();
                flagValorPreenchido = true;
                this.opr = opr;
            }
            flagVirgula = false;
        }

        public string realizaOperacao(double valor1, double valor2, char opr)
        {
            if(valor1 != 0)
            {
                this.valor1 = valor1;
            }
            switch (opr) {             
                case '+':
                    resultado = valor1 + valor2;
                    break;
                case '-':
                    resultado = valor1 - valor2;
                    break;
                case '/':
                    if(valor1 != 0 && valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        txtboxNumeros.Text = "Err";
                    }
                    break;
                case '*':
                    resultado = valor1 * valor2;
                    break;
                case 'p':
                    resultado = Math.Pow(valor1, valor2);
                    break;
            }
             
            return resultado.ToString();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = digitaVerificaZero(txtboxNumeros.Text, 1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = digitaVerificaZero(txtboxNumeros.Text, 2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = digitaVerificaZero(txtboxNumeros.Text, 3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = digitaVerificaZero(txtboxNumeros.Text, 4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = digitaVerificaZero(txtboxNumeros.Text, 5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = digitaVerificaZero(txtboxNumeros.Text, 6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = digitaVerificaZero(txtboxNumeros.Text, 7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = digitaVerificaZero(txtboxNumeros.Text, 8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = digitaVerificaZero(txtboxNumeros.Text, 9);
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = digitaVerificaZero(txtboxNumeros.Text, 0);
        }

        private void btnMaisMenos_Click(object sender, RoutedEventArgs e)
        {
            int numeroInvertido = -int.Parse(txtboxNumeros.Text);
            txtboxNumeros.Text = numeroInvertido.ToString();
        }

        private void btnVirg_Click(object sender, RoutedEventArgs e)
        {
            if (!flagVirgula)
            {
                txtboxNumeros.Text += ',';
                flagVirgula = true;
            }
        }

        private void btnBckspc_Click(object sender, RoutedEventArgs e)
        {
            char ultimo = txtboxNumeros.Text.Last();
            if(txtboxNumeros.Text.Last() == ',')
            {
                flagVirgula = true;
            }
            if(txtboxNumeros.Text.Length > 1)
            {
                txtboxNumeros.Text = txtboxNumeros.Text.Substring(0, txtboxNumeros.Text.Length - 1);
            }
            else
            {
                txtboxNumeros.Text = 0.ToString();
            }
        }

        private void btnMais_Click(object sender, RoutedEventArgs e)
        {
            salvaValor1('+');
        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            salvaValor1('-');
        }

        private void btnVezes_Click(object sender, RoutedEventArgs e)
        {
            salvaValor1('*');
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            salvaValor1('/');
        }

        private void btnPow_Click(object sender, RoutedEventArgs e)
        {
            salvaValor1('p');
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumeros.Text = Math.Sqrt(double.Parse(txtboxNumeros.Text)).ToString();
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            if (flagValorPreenchido)
            {
                valor2 = double.Parse(txtboxNumeros.Text);
                double valorHistorico = double.Parse(realizaOperacao(valor1, valor2, opr));
                txtboxNumeros.Text = valorHistorico.ToString();
                ListBoxItem teste = new ListBoxItem();
                teste.Content = valor1 + " " + opr + " " + valor2 + " = " + valorHistorico;
                lbHistory.Items.Add(teste);
                if (lbHistory.Items.Count > 0)
                {
                    lbHistory.ScrollIntoView(lbHistory.Items[lbHistory.Items.Count - 1]);
                }
                valor1 = 0;
                valor2 = 0;
                flagValorPreenchido = false;
                flagVirgula = false;

            }
        }

        private void btnM_Click(object sender, RoutedEventArgs e)
        {
            if (!valorMemoria.HasValue)
            {
                valorMemoria = double.Parse(txtboxNumeros.Text);
                txtboxNumeros.Text = "0";
            }
            else
            {
                txtboxNumeros.Text = valorMemoria.ToString();
                valorMemoria = null;
            }
        }
    }
}
