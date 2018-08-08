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
        bool flag = true;
        float valor1 = 0;
        float valor2 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public string digitaVerificaZero(string valor, int num)
        {
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
            if (flag)
            {
                txtboxNumeros.Text += ',';
                flag = false;
            }
        }

        private void btnBckspc_Click(object sender, RoutedEventArgs e)
        {
            char ultimo = txtboxNumeros.Text.Last();
            if(txtboxNumeros.Text.Last() == ',')
            {
                flag = true;
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
            valor1 = float.Parse(txtboxNumeros.Text);
            txtboxNumeros.Text = 0.ToString();
        }
    }
}
