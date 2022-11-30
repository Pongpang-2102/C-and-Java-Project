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

namespace Academy04__WPF___calculator_
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




        private void CalButton_Click(object sender, RoutedEventArgs e)
        {
            int x;
            try
            {
                x = Convert.ToInt32(txtX.Text);  // change x (string) to Interger and store it in x
            }
            catch (Exception)
            {
                MessageBox.Show("x is not a number");
                txtX.Focus();
                return;
            }
            int y;
            try
            {
                y = Convert.ToInt32(txtY.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("y is not a number");
                txtY.Focus();
                return;
            }

            MessageBox.Show($"The result is {x + y}");
        }
    }
}
