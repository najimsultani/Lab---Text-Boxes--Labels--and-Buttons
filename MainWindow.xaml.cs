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

namespace WpfApptest2
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

        double number1, number2;
        private void Numberparse()
        {
            double.TryParse(TBnumber1.Text, out number1);
            double.TryParse(TBnumber2.Text, out number2);

        }
        private void BT_ClickAdd(object sender, RoutedEventArgs e)
        {
            Numberparse();
            TBresult.Text = (number1 + number2).ToString();  
        }

        private void BT_ClickSub(object sender, RoutedEventArgs e)
        {
            Numberparse();
            TBresult.Text = (number1 - number2).ToString();
        }

        double number3, number4;
        private void Twoparse()
        {
            double.TryParse(TBnumber3.Text, out number3);
            double.TryParse(TBnumber4.Text, out number4);

        }
        private void BT_ClickMul(object sender, RoutedEventArgs e)
        {
            Twoparse();
            TBresult2.Text = (number3 * number4).ToString();
        }
        private void BT_ClickDiv(object sender, RoutedEventArgs e)
        {
            Twoparse();
            TBresult2.Text = (number3 / number4).ToString();
        }

        private void BT_ClickAve(object sender, RoutedEventArgs e)
        {
            double result1, result2 = 0;

            bool result1IsANumber = double.TryParse(TBresult.Text, out result1);
            bool result2IsANumber = double.TryParse(TBresult2.Text, out result2);

            if (result1IsANumber && result2IsANumber)
            {
                double average = (result1 + result2) / 2;
                TBresult3.Text = average.ToString();
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

       

    }
}
