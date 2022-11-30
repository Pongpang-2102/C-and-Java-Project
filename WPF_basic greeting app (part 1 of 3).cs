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

namespace _18_Oct_22_Pongpang_Greeting_App
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 1. assigning variable to store customer name
            string customer_name = input_name.Text;
            if (customer_name == " ")      // ไม่ควรมีอ "" และ ตัวเลข
             {
                MessageBox.Show("โปรดตรวจสอบความถูกต้องของชื่อของท่าน");
                return;

            }



            // 2. assigning variable to store customer age

            DateTime? birthday = BirthdayDatePicker.SelectedDate;
            if (birthday == null)
            {

                MessageBox.Show("โปรดตแก้ไขวันที่");
                BirthdayDatePicker.Focus();
                return;
            }


                DateTime birthDateTime = birthday.Value;
            int birthYear = birthDateTime.Year;
            int ThisYear = DateTime.Today.Year;
            int customer_age = ThisYear - birthYear;


            // 3. assigning variable to store customer gender

            var customer_gender = cmbOperation.SelectedItem as ComboBoxItem; // ลองแก้ combobox เป็น swich case
            string cus_gender = customer_gender.Content as string; // ดึง data gender ออกมา


            // 4. add if-else statement for case of customer name = ""
            //         and customer Birthday would not be selected

            //if (customer_name != "" && birthday != null && customer_age !< 0)

            if (customer_name == " " || birthday == null)
            {

                MessageBox.Show("โปรดตรวจสอบความถูกต้องของข้อมูลอีกครั้ง\"");
                BirthdayDatePicker.Focus();
                return;
            }
            else if (customer_age < 0)
                {
                    MessageBox.Show("โปรดตรวจสอบความถูกต้องของข้อมูลอีกครั้ง");
                    BirthdayDatePicker.Focus();
                    return;

                // 4.1 age not over 12
                }
            else if (customer_age >= 0 && customer_age <= 12 && cus_gender == "ชาย")
                {
                    MessageBox.Show($"สวัสดีครับน้อง {customer_name}");

                }
             else if (customer_age >= 0 && customer_age <= 12 && cus_gender == "หญิง")
                {
                    MessageBox.Show($"สวัสดีครับหนู {customer_name}");

                }
                // 4.2 age between 13 to 59
              else if (customer_age < 60)
                {
                    MessageBox.Show($"สวัสดีครับคุณ {customer_name}");
                }

                // 4.4 age 60 and less than 
              else if (customer_age >= 60 && cus_gender == "ชาย")
                {
                    MessageBox.Show($"สวัสดีครับคุณลุง {customer_name}");
                }
              else if (customer_age >= 60 && cus_gender == "หญิง")
                {
                    MessageBox.Show($"สวัสดีครับคุณป้า {customer_name}");
                }
              else if (customer_age >= 140)
                {
                    MessageBox.Show("โปรดตรวจสอบความถูกต้องของข้อมูลอีกครั้ง");
                    BirthdayDatePicker.Focus();
                    return;
                }
                }
            }
        }
    
