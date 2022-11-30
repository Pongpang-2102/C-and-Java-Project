using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Oct_22_Academy_csv_process
{
    internal class EmailRecord
    {
        public string Email { get; set; }
        public DateTime Date { get; set; } // date ตรงนี้คือ วันที่ send email
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
     
