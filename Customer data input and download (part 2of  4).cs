using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_oct_22_Academy02_Customer_Info
{
    class Customer // ไม่ต้องใส่ class หน้า Public ก็ได้ ไม่มีผลต่อการเรียกค่า
    {
        public string FirstName { get; set; } // public จะเป็นการประกาศให้ตัวแปรนี้สามารถใช้่ได้นอก class // private จะใช้ได้แค่ใน class เท่านั้่น (as default value)
                                              // public ใส่เพื่อให้คนนอก class เข้ามาใช้งานได้ get or get set

        // public string FirstName ถ้าประกาศแบบนี้เพื่อให้คนนอกเข้ามาใช้งานค่าได้ ดึงค่าได้อย่างเดียว {get;} ดึงและเซต {get;set ;}

        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; } // DateTime? ตัว ? เป็นการอนุญาตให้ Birthdate สามารถเป็น null value ได้
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
