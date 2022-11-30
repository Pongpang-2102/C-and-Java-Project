using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace _20_Oct_22_Academy01_Area_Calc
{
    internal class Rectangle : shape // this is  inherit --> class extension บอกว่า Regtangle ขยายมาจาก shape -- 1.1 ถ้า extend ตรงนี้
    {
        public Rectangle (double w , double h): base (w, h) //--1.2 ก็ต้อง extend ตรงนี้ด้วย // ไม่สำคัญที่พารามิเตอร์ชื่ออะไร สำคัญที่ตัวไหนมาก่อนหลัง
        {
            //  value will be sent from Regtangle (or son as Constructor) to Shape (or Parent)to calculate value

        }

        // สมมติว่าเราอยากเพิ่ม parameter thickness
        /* 
        public Rectangle(double w, double h) : base(w, h , t)
        {

        }
        */

        // code ด้านล่าง สีฟ้า ใช้ var ไม่ได้ เนื่องจาก var ใช้รับค่าอย่างเดียว
        
        public override double GetArea()               // override คือการขออนุญาตโปรแกรมเขียนทับ (overwrite ) ฟังก์ชันเดิมของ Class แม่ เวลาดูข้อผิดพลาดจะได้ recheck กลับไปที่ class แม่ด้วย
                    
        {


            return Width * Height;         //
        }
        
    }

   
}


//var ไว้รับค่าอย่างเดียว
// Constructor มีได้หลายอัน แต่รูปแบบห้ามซ้ำ
