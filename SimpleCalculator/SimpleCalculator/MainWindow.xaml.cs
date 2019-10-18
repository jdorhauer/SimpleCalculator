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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long NumOne = 0;
        long NumTwo = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne *= -1;
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo *= -1;
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = (NumOne * 10) + 1;
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo = (NumTwo * 10) + 1;
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = (NumOne * 10);
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo = (NumTwo * 10);
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = (NumOne * 10) + 2;
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo = (NumTwo * 10) + 2;
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = (NumOne * 10) + 3;
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo = (NumTwo * 10) + 3;
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = (NumOne * 10) + 4;
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo = (NumTwo * 10) + 4;
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = (NumOne * 10) + 5;
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo = (NumTwo * 10) + 5;
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = (NumOne * 10) + 6;
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo = (NumTwo * 10) + 6;
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = (NumOne * 10) + 7;
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo = (NumTwo * 10) + 7;
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = (NumOne * 10) + 8;
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo = (NumTwo * 10) + 8;
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = (NumOne * 10) + 9;
                txtDisp.Text = NumOne.ToString();
            }
            else
            {
                NumTwo = (NumTwo * 10) + 9;
                txtDisp.Text = NumTwo.ToString();
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisp.Text = "0";
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisp.Text = "0";
        }

        private void BtnMult_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisp.Text = "0";
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisp.Text = "0";
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    NumOne = (NumOne + NumTwo);
                    break;
                case "-":
                    NumOne = (NumOne - NumTwo);
                    break;
                case "/":
                    NumOne = (NumOne / NumTwo);
                    break;
                case "*":
                    NumOne = (NumOne * NumTwo);
                    break;
            }
            txtDisp.Text = NumOne.ToString();
            NumTwo = 0;
            operation = "";
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                NumOne = 0;
            }
            else
            {
                NumTwo = 0;
            }

            txtDisp.Text = "0";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            NumOne = 0;
            NumTwo = 0;
            operation = "";
            txtDisp.Text = "0";
        }
    }
}
