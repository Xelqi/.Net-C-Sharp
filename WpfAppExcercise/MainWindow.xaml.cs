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

namespace WpfAppExcercise
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

        int numA;
        int numB;
        int numC;

        private void calcBtn(object sender, RoutedEventArgs e)
        {
            numA = Convert.ToInt32(num1.Text);
            numB = Convert.ToInt32(num2.Text);
            if (RadioPlus.IsChecked == true)
            {
                numC = numA + numB;
                result.Content = "Result is : " + numC.ToString();

            }
            if (RadioMinus.IsChecked == true)
            {
                numC = numA - numB;
                result.Content = "Result is : " + numC.ToString();
            }
            if (RadioProduct.IsChecked == true)
            {
                numC = numA * numB;
                result.Content = "Result is : " + numC.ToString();
            }
            if (RadioQuotient.IsChecked == true)
            {
                numC = numA / numB;
                result.Content = "Result is : " + numC.ToString();
            }
        }
    }
}
