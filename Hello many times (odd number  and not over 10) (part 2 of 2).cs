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

namespace _19_Oct_22_Academy01
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

        private void Button_click(object sender, RoutedEventArgs e)
        {
            var name = txtName.Text;
            int age;
            try
            {
                age = Convert.ToInt32(txtAge.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid age");
                txtAge.Focus();
                return; // ไม่ใส่ตรงนีี้ age ข้างล่างมีโอกาสที่จะ error

            }




            /*
            int count = 1;
            while (count <= age)
            {
                MessageBox.Show($"Happy birthday {name} #{count}");
                count++;
            }
            */
            


            // same condition but use for loop instead
            for (int count = 1; count <= age  ; count++){

                if (count % 2 == 1) continue;                           // statement เดียว ไม่ต้องมีปีกกาก็ได้ --> continue จะ check condition รอบถัดไปได้เลย
                if (count > 10) break;
                MessageBox.Show($"Happy birthday {name} #{count}");
            }

            MessageBox.Show("Done");




        }

    }
}
