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
    class Thai : IemailGenerator
    {

        public EmailRecord Generate(string firstname, string lastname, int year, string email, DateTime? birthDate)
        {
            DateTime birthDateTime = birthDate.Value;   //.value  คือการดึงค่าที่รู้ว่าไม่ null แน่ ๆ ออกมา
            DateTime sendDate = birthDate.Value.AddYears(year);

            // create a variable named :record to store email record (will be duplicated later)
            var record_th = new EmailRecord()
            {
                Email = email,
                Date = sendDate,
                Subject = $"สุขสันต์วันเกิดในปีที่ {year} ครับ",
                Content = $"สวัสดีครับคุณ {firstname} {lastname}, สุขสันต์วันเกิดปีที่ {year} ครับ"


            };
            // Return email record
            return record_th;




        }
    }
}




/*

                using (var writer = new StreamWriter(dialog.FileName))
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
