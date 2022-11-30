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
using System.Windows.Shapes;

namespace _21_oct_22_Customer_DB_app
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        Customer editingCustomer;
        public CustomerWindow(Customer editingCustomer = null) // user ไม่ใส่ชื่อมา ถือว่า null เลยไม่ได้แก้อะไร   /// ตอนแรก CustomerWindow ติดตัวแดง เราไปแก้ class customer จาก internal class -- > public class ---> OK
        {
            InitializeComponent();
            this.editingCustomer = editingCustomer;  // this ?????????

            if (editingCustomer != null)
            {
                // load data to control (load to textbox)
                txtFirstName.Text = editingCustomer.FirstName;
                txtLastName.Text = editingCustomer.LastName;
                GenderComboBox.SelectedItem = editingCustomer.Gender;   
            }
        }

  
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            // save customer data to database
            //CustomerDatabase.Instance.AddCustomer(customer);

            // Validating our new added data

            // validate first name (from text box)
            string firstName = txtFirstName.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter first name");
                txtFirstName.Focus();
                return;
            }
            // validate lastname (from text box)
            string lastName = txtLastName.Text;
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter last Name");
                txtLastName.Focus();
                return;
            }

            // validate gender (from combo box)
            string gender = GenderComboBox.SelectedItem as string;
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select gender");
                GenderComboBox.Focus();
                return;

            }
            // case separation
            Customer customer;
             if (editingCustomer != null)
            {
               customer = editingCustomer;
            }
            else
            {
                customer = new Customer();
            }

            // กำหนดค่าใส่ Customer
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Gender = gender;




            //เอาไปอัพเดท หรือ add เข้า database

            if (editingCustomer != null)
            {
                var customerList = CustomerDatabase.Instance.GetCustomers();
                int indexCustomer = 0; 
                for (int index = 0; index < customerList.Count(); index ++)
                {
                    if (customerList[index].FirstName == editingCustomer.FirstName &&
                        customerList[index].LastName == editingCustomer.LastName)
                    {
                        indexCustomer = index;
                        break;
                    }
                }
                CustomerDatabase.Instance.UpdateCustomer(customer , indexCustomer);
            }
            else
            {
                CustomerDatabase.Instance.AddCustomer(customer);
            }

            //close window after data has been added 
            Close();
        }
    }
}
