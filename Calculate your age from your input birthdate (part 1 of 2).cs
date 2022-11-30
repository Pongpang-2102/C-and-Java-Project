using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace _18_Oct_22_Academy3
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

        private void Calculate_button_Click(object sender, RoutedEventArgs e)
        {
            //DateTime? testDateTime = null;

            DateTime? birthday = BirthdayDatePicker.SelectedDate; // เนื่องจากบางที user อาจจะไม่ได้กรอกวันที่มาให้เรา
            // ตัวที่มี question mark แบบนี้ จะต้องตามด้วย .value หากต้องการที่จะดึงค่าออกมา (ข้อมูลตัวนี้จะมีหรือไม่มีค่าก็ได้)
            if (birthday == null)
            {
                MessageBox.Show("Please select birthday");
                BirthdayDatePicker.Focus();
                return;
            }
            DateTime birthDateTime = birthday.Value;
            int birthYear = birthDateTime.Year;

            int ThisYear = DateTime.Today.Year;

            int age = ThisYear - birthYear;





            // if you need to change your language from default setting on your pc to date in English format

            /*
            FormattableString formattableString = $"Your birthdayy is {birthday: d MMM yyyy}. Your age is {age}";
            string result = formattableString.ToString(CultureInfo.InvariantCulture);
            MessageBox.Show(result);
            */

            // Convert from English Date to Thai date (e.g. ปี 4 digit ในหน่วย พ.ศ หรือ มี.ค

            FormattableString formattableString = $"Your birthday is {birthday: d MMM yyyy}. Your age is {age}";
            string result = formattableString.ToString(CultureInfo.InvariantCulture); // English Language date
            //string result = formattableString.ToString(new CultureInfo("th-TH"));
            //string result = formattableString.ToString(new CultureInfo("en-EN"));
            MessageBox.Show(result);
            //MessageBox.Show(formattableString.ToString()  );




            //MessageBox.Show($"Your birthday is {birthday: dddd dd-MMM-yyyy}. Your age is {age}"); 
            // It would be default language (base on your PC setting)




        }
    }
}
