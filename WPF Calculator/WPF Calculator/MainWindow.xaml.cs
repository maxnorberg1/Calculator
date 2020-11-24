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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (MyTextBlock.Text.Contains('+'))
            {
                var tal1 = Convert.ToDouble(MyTextBlock.Text.Split('+')[0]);
                var tal2 = Convert.ToDouble(MyTextBlock.Text.Split('+')[1]);
                var summa = tal1 + tal2;
                MyTextBlock.Text = summa + "";
            }
            else if (MyTextBlock.Text.Contains('-'))
            {
                var tal1 = Convert.ToDouble(MyTextBlock.Text.Split('-')[0]);
                var tal2 = Convert.ToDouble(MyTextBlock.Text.Split('-')[1]);
                var summa = tal1 - tal2;
                MyTextBlock.Text = summa + "";
            }
            else if (MyTextBlock.Text.Contains('/'))
            {
                var tal1 = Convert.ToDouble(MyTextBlock.Text.Split('/')[0]);
                var tal2 = Convert.ToDouble(MyTextBlock.Text.Split('/')[1]);
                var summa = tal1 / tal2;
                MyTextBlock.Text = summa + "";
            }
            else if (MyTextBlock.Text.Contains('*'))
            {
                var tal1 = Convert.ToDouble(MyTextBlock.Text.Split('*')[0]);
                var tal2 = Convert.ToDouble(MyTextBlock.Text.Split('*')[1]);
                var summa = tal1 * tal2;
                MyTextBlock.Text = summa + "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                switch (button.Content)
                {
                    case "+":
                    case "*":
                    case "/":
                    case "-":
                        if (MyTextBlock.Text.Contains("+") || MyTextBlock.Text.Contains("-") || MyTextBlock.Text.Contains("*") || MyTextBlock.Text.Contains("/"))
                        {
                            break;
                        }
                        MyTextBlock.Text += button.Content;
                        break;

                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":


                        MyTextBlock.Text += button.Content;
                        break;

                    case "CE":
                        MyTextBlock.Text = "";
                        break;
                    default:
                        MyTextBlock.Text += "";
                        break;
                }

            }
        }
    
    }
}
