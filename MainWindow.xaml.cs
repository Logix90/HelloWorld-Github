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

namespace HelloWorld_Github
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

        int number = 0;

        private void btnHelloWorld_Click(object sender, RoutedEventArgs e)
        {
            if (number == 0)
            {
                txtResult.Text = "Hello World";
            }
            else if (number == 1)
            {
                txtResult.Text = "Don't push twice!!!!!!!";
            }
            else if (number == 2)
            {
                txtResult.Text = "three times is the limit !!!";
            }
           
            number++;
            lblNumber.Content = number;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            lblNumber.Content = number;
        }
    }
}
