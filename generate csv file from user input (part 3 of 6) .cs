using CsvHelper;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace _19_Oct_22_Academy_csv_process
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

        private void Gen_btn_Click(object sender, RoutedEventArgs e)
        {
            // verify first name
            string FirstName = txtFirstName.Text;
            if (string.IsNullOrEmpty(FirstName))
            {
                MessageBox.Show("Please enter First Name ");
                txtFirstName.Focus();
                return;
            }

            // verify last name
            string LastName = txtLastName.Text;
            if (string.IsNullOrEmpty(LastName))
            {
                MessageBox.Show("Please enter Last Name ");
                txtLastName.Focus();
                return;
            }



            // to check whether birthdate is null
            DateTime? birthDate = dpBirthDate.SelectedDate;


            // to check whether number of year input is correct
            // using try catch
            int years;
            try
            {
                years = Convert.ToInt32(txtYear.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid number of Years");
                txtYear.Focus();
                return;

            }

            // to verify your input email
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter Email");
                txtEmail.Focus();
                return;
            }

            // Email validation using Regex
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("Invaid Email");
                txtEmail.Focus();
                return;
            }
            // create a dialog box
            var dialog = new SaveFileDialog() { DefaultExt = "csv", Filter = "CSV Files|*.csv" };
            //ComboBoxItem language = cmbLanguage.SelectedItem as ComboBoxItem;
            //string str_language = language.Content as string;

            //string str_language = cmbLanguage.SelectedItem as string;

            string string_language = cmbLanguage.SelectedItem as string;
            
            if (string.IsNullOrEmpty(string_language))
            {
                MessageBox.Show("Please select language");
                cmbLanguage.Focus();  // เหมือน cursor กระพริบ
                return;
            

            }
            
            //  // use switch case for separate thai and english language process

            // call interface
            IemailGenerator language_selected;

            // switch case 

            switch (string_language)
            {
                case "English":
                    language_selected = new English();
                    break;

                case "Thai":
                    language_selected = new Thai();
                    break;

                default:
                    MessageBox.Show($"Unknown Language");
                    return;

            }


            // save file

            if (dialog.ShowDialog() == true)
            {
                var records = new List<EmailRecord>(); // create an empty list to store email records [n0,n1,n2,......]

                for (int year = 1; year <= years; year++)
                {
                    EmailRecord message_birthday = language_selected.Generate(FirstName, LastName, year, email, birthDate);
                    records.Add(message_birthday);





                }

                using (var writer = new StreamWriter(dialog.FileName , false , Encoding.UTF8))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                }

                MessageBox.Show($"File has been saved to {dialog.FileName}");

                // to create a log in file generation

                foreach (var item in records)
                {
                    Debug.WriteLine(item.Subject);
                }

            }
        }
    }
}

