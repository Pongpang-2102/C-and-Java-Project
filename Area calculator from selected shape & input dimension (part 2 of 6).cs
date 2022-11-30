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

namespace _20_Oct_22_Academy01_Area_Calc
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

        private void btn_calculate_Click(object sender, RoutedEventArgs e)
        {
            string shape = cmbShape.SelectedItem as string;
            if (shape == null)
            {
                MessageBox.Show("Please select shape");
                cmbShape.Focus();
                return;
            }

            // validate variable width
            int width;
            try
            {
                width = Convert.ToInt32(txtWidth.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Width");
                txtWidth.Focus();
                return;
            }
            // validate variable height

            int height;
            try
            {
                height = Convert.ToInt32(txtHeight.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Height");
                txtHeight.Focus();
                return;
            }

            shape shapeObject;
            switch (shape)
            {
                case "Rectangle":
                    shapeObject = new Rectangle(width, height);
                    break;
                case "Triangle":
                    shapeObject = new Triangle(width, height);
                    break;
                case "Elipse":
                    shapeObject = new Elipse (width, height);
                    break;
                default:
                    MessageBox.Show($"Unknown shape {shape}");
                    return;


            }

            var area = shapeObject.GetArea();

            MessageBox.Show($"The area is {area}");


        }
    }
}
