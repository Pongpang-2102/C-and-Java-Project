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

namespace _21_oct_22_Customer_DB_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // ?????????
            CustomerDatabase customerDatabase = CustomerDatabase.Instance;
            CustomerListBox.ItemsSource = customerDatabase.GetCustomers(); // ขอ Object ตัวเดียวนั่นมาใช้หน่อย 

            UpdateButtonStatus();  

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow customerWindow = new CustomerWindow();
            customerWindow.ShowDialog(); // show หน้าต่างใหม่ ทับหน้าต่างเก่า

            CustomerListBox.Items.Refresh(); // ไปดู resource refresh ว่ามีข้อมูลอะไรบ้าง จะได้เอามาแสดงถูก
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Customer selected_customer = CustomerListBox.SelectedItem as Customer;
            if (selected_customer != null)
            {
                // to display message box (asking to confirm that your selected customers is correct)
                var messageBoxResult = MessageBox.Show($"Do you really want to delete {selected_customer.FirstName} {selected_customer.LastName} ?",
                    "Delete", // this is window coption (top left) 
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);

                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    CustomerDatabase.Instance.DeleteCustomer(selected_customer);
                    CustomerListBox.Items.Refresh();  // display customer info after old list has been deleted
                }

            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Customer selected_customer = CustomerListBox.SelectedItem as Customer;
            if (selected_customer != null)
            {
                CustomerWindow customerwindow = new CustomerWindow(selected_customer);
                customerwindow.ShowDialog();
                CustomerListBox.Items.Refresh();
            }

        }


        // to enable edit button when customer is selected
        void UpdateButtonStatus()
        {
            bool isButtonEnabled;
            Customer selectedCustomer = CustomerListBox.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                isButtonEnabled = true;
            }
            else
            {
                isButtonEnabled = false;
            }

            EditButton.IsEnabled = isButtonEnabled;
            DeleteButton.IsEnabled = isButtonEnabled;

        }

        private void CustomerListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateButtonStatus();
        }
    }
}
