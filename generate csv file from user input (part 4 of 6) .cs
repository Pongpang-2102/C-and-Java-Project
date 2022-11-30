using _19_Oct_22_Academy_csv_process;
using CsvHelper;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _19_Oct_22_Academy_csv_process
{
    class English : IemailGenerator
    {


        public EmailRecord Generate(string firstname, string lastname, int year, string email, DateTime? birthDate)
        {
            DateTime birthDateTime = birthDate.Value;   //.value  คือการดึงค่าที่รู้ว่าไม่ null แน่ ๆ ออกมา
            DateTime sendDate = birthDate.Value.AddYears(year);
           
            string suffix_eng;

            // Specify a suffix in your birthday anniversary

            if (year >= 11 && year <= 13)
                suffix_eng = "th";
            else if (year % 10 == 1)
                suffix_eng = "st";
            else if (year % 10 == 2)
                suffix_eng = "nd";
            else if (year % 10 == 3)
                suffix_eng = "rd";
            else
                suffix_eng = "th";


            // create a variable named :record to store email record (will be duplicated later)
            var record_eng = new EmailRecord()
            {
                Email = email,
                Date = sendDate,
                Subject = $"Happy birthday your {year}{suffix_eng} birthday",
                Content = $"Hi {firstname} {lastname}, Happy birthday your {year}{suffix_eng} birthday"

            };
            // Return email record
            return record_eng;







        }
    }


}



/*


{
    // create a loop for sending a birthday message
    for (int year = 1; year <= years; year++)
    {
        



    

             /*   using (var writer = new StreamWriter(dialog.FileName))
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

    */
