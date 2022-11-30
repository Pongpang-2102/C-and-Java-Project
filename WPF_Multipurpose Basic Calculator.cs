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

namespace _18_Oct_22_Academy02
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

    
        private void calculate_button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = cmbOperation.SelectedItem as ComboBoxItem; // In cmb , Any Item can be added -- change it to combobox item
                                                                          // ถ้าใช้ค่าเป็น ComboBox Item สามารถตั้งค่าอื่น ๆ เพิ่มเติมได้ เช่น set สี แล้วค่อยไปเปลี่ยนเป็น string
                                                                           // ถ้าใช้เป็น as string code ตรงส่วนนี้ก็จะสั้นดี แตาเรา seะ ลูกเล่นได้น้อยกว่า
            if (selectedItem == null) // ถ้าไม่ได้เลือกอะไรใน comboBox Item
            {
                MessageBox.Show("Invalid Operation");
                return;
            }

            var operation = selectedItem.Content as string; // ถ้าบรรทัดที่ 31 ถูกลบ เราจะรู้แค่ว่าต้องแปลงค่าจาก object ซักอันให้เป็น string แต่ไม่รู้ว่าซักอันนั่นคืออันไหน -- error

            MessageBox.Show(operation);

            try
            {
                var values = new List<int>(); // Declare a new variable
                // list สำหรับ C# ไม่ใช่ตัวแปรพื่นฐานทั่วไป แต่เป็น Object ชนิดนึง เลยต้องประกาศ New
                values.Add(Convert.ToInt32(text1.Text));
                values.Add(Convert.ToInt32(text2.Text));
                values.Add(Convert.ToInt32(text3.Text));
                values.Add(Convert.ToInt32(text4.Text));
                values.Add(Convert.ToInt32(text5.Text));

                // {10,9,8,7,6}

                var valueText1 = values[0];
                var valueText2 = values[1];

                var value1 = Convert.ToInt32(text1.Text);
                var value2 = Convert.ToInt32(text2.Text);
                var value3 = Convert.ToInt32(text3.Text);
                var value4 = Convert.ToInt32(text4.Text);
                var value5 = Convert.ToInt32(text5.Text);

                int result;
                switch (operation)  // switch ว่าจะทำอะไร summary--?? , max -- ???
                {
                    case "Summary":
                        //result = value1 + value2 + value3 + value4 + value5;
                        result = values.Sum();
                        break;

                    case "Max":
                        /*result = Math.Max(value1, value2);
                        result = Math.Max(result, value3);
                        result = Math.Max(result, value4);
                        result = Math.Max(result, value5);*/

                        result = values.Max(); // easier writing

                        break;

                    case "Min":
                        /*result = Math.Min(value1, value2);
                        result = Math.Min(result, value3);
                        result = Math.Min(result, value4);
                        result = Math.Min(result, value5);*/

                        result = values.Min(); // easier writing
                        break;

                    default: // case ที่เหลือนอกจากที่ switch ระบุ
                        MessageBox.Show("Unknown Operation");
                        return;

                        // if-else can be used in this case

                }

                MessageBox.Show("The Result is " + result);


            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Number");
                return;
            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
