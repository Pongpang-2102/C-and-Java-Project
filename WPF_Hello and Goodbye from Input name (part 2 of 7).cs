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

namespace _20_Oct_22_Academy02
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

        private void btn_greet_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter name");
                txtName.Focus();
                return;
            }

            string greeter = cmbGreeter.SelectedItem as string;
            if (greeter == null)
            {
                MessageBox.Show("Please select greater");
                cmbGreeter.Focus();
                return ;
            }

            IGreeterAndFarewell myGreeter;
            //IFarewell myGreeter;
            //IGreeter myGreeter;
            switch (greeter)
            {
                case "Formal":
                    myGreeter = new FormalGreeter();
                    break;
                case "Friendly":
                    myGreeter = new FriendlyGreeter();
                    break;
                default:
                    MessageBox.Show($"Unknown greeter {greeter}");
                    return;

            }

            string messageGreet = myGreeter.Greet(name);
            string messageFarewell = myGreeter.Farewell(name);
            //MessageBox.Show(message);
            MessageBox.Show(messageGreet);
            MessageBox.Show(messageFarewell);

        }
    }
}
