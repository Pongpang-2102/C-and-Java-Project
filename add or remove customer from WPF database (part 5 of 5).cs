using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace _21_oct_22_Customer_DB_app
{
    internal class CustomerDatabase
    {
        List<Customer> customers; // ระวังไม่ให้ list ชื่อซ้ำกันกับ class

        // to prevent incorrect file name input problem
        // we will assign variable and specify json file name before using other function

        string customers_fileName = "customers.json";

        // static - บอกว่าตัวแปรด้านหลังคำนี้เป็นของ class ไม่ใช่ของ object (เช่น ไม่ต้อง New Customer Database)


        public static CustomerDatabase Instance { get; } = new CustomerDatabase(); 

        CustomerDatabase()
        {
            LoadDatabase();
        }

        public List<Customer> GetCustomers() //display customer list to user
        {
            return customers;
        }


        public void AddCustomer(Customer customer)
        {
            customers.Add(customer); // add DB to list
            SaveDatabase(); //save data from list to file after pressing ADD button 
        }

        public void DeleteCustomer (Customer customer)
        {
            // to display message box (asking to confirm that your selected customers is correct)


            // to remove selected customer
            customers.Remove(customer); // remove customer list member from customer list
            SaveDatabase(); // save data from list to file after pressing DELETE button on main window (to display in next time request)
        }

        public void UpdateCustomer (Customer customer , int index) // 
        {
            customers[index] = customer;
            SaveDatabase(); // save whole list of customer to file
        }

        void LoadDatabase()
        {
            //load database from file to customer variable

            // to check whether cusomer json has been created before
            if (File.Exists(customers_fileName)) 

            {
                // load from file
                string json = File.ReadAllText(customers_fileName); // read info from existed customer database
                customers = JsonSerializer.Deserialize<List<Customer>>(json);
            }
            else
            {
                // create a new emtpy list
                // For first day of working , we have no document file , customer.json will be created
                customers =  new List<Customer> ();
            }
            
        }
        void SaveDatabase()
        {
            // save dababase from customer variable to file
            string json = JsonSerializer.Serialize(customers); // save customer as json format
            File.WriteAllText(customers_fileName, json);
        }

    }
}
