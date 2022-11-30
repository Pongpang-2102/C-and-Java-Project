using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;

namespace _19_oct_22_Academy02_Customer_Info
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // Null - ค่าว่าง ไม่มีค่าอะไรเลยในตัวแปร 
            // 2 ตัวนี้ไม่เท่ากัน
            //string name = null !=  name = ""


        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            //var customer = new Customer();

            Customer customer = new Customer()
            {

                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = dp_Birthdate.SelectedDate,
                Address = txtAddress.Text,
                PhoneNumber = txtPhone_Number.Text,
                Email = txtEmail.Text,
            };

            // validate phone
            var phoneRegex = new Regex("^0[0-9]{9}$");
            if (!phoneRegex.IsMatch(customer.PhoneNumber))
            {
                MessageBox.Show("Invaild Phone Number");
                txtPhone_Number.Focus();
                return;
            }

            // validate email
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailRegex.IsMatch(customer.Email))
            {
                MessageBox.Show("Invalid Email Address");
                txtEmail.Focus();
                return;
            }





                /*customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.BirthDate = dp_Birthdate.SelectedDate;
                customer.Address = txtAddress.Text;
                customer.PhoneNumber = txtPhone_Number.Text;
                customer.Email = txtEmail.Text;*/

                // create a new function for saving file later
                // นึกถึงตอนเรา download file แล้วมันขึ้นที่ให้เลือก save file

                var dialog = new SaveFileDialog() 
                { 
                    DefaultExt = "json", // เป็นการกำหนดนามสกุลไฟล์ให้เราหลังจากเรากดปุ่ม save file ถ้าเราไม่ใส่เราอาจจะต้องมาพิมพ์เองหมด เช่น pongpang.json
                    Filter = "JSON files|*.json" // ไปโผล่ตรง save as type
                    //Filter = "JSON files|*.json|Text files|*.txt"    // ถ้าอยาก savae หลาย filter ก็ Pipe ต่อไป
                }; // ต้่อง add  using Microsoft.Win32; ข้างบนสุดก่อน

            var dialogResult = dialog.ShowDialog();
            if (dialogResult == true)
            {
                // save file
                var filepath = dialog.FileName; // สร้าง path การเก็บ นำค่ามาจาก path ยาว ๆ ข้างบนไฟล์ลิสต์ บวกกับ filename ที่เราสร้างขึ้นมา
                var json = JsonSerializer.Serialize(customer); // แปลงค่า class เป็น stringJSON

                File.WriteAllText(filepath, json); // เอาค่า string มา "เขียน (write)" เป็น text ตามค่าที่เรา set dialog ไว้ (ในที่นี้กำหนดให้เก็บเป็น json file)

                MessageBox.Show($"File has been saved to {filepath}");
            }
        }

        private void btn_load_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                DefaultExt = "json",
                Filter = "JSON files|*.json"
            };

            var dialogResult = dialog.ShowDialog();
            if (dialogResult == true)
            {
                // load file
                var filepath = dialog.FileName; // สร้าง path การเก็บ
                var json = File.ReadAllText(filepath); // แปลงค่า class เป็น string
                var customer = JsonSerializer.Deserialize<Customer>(json); // บอกว่าต้องการให้ออกมาเป็น class ประเภทไหน ในที่นี้คือ class Customer

                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                dp_Birthdate.SelectedDate = customer.BirthDate;
                txtAddress.Text = customer.Address;
                txtPhone_Number.Text = customer.PhoneNumber;
                txtEmail.Text = customer.Email;

                MessageBox.Show($"FIle {filepath} hase been loaded");
            }
        }
    }
}


