using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Oct_22_Academy01_Area_Calc
{
    abstract class shape // abstract หน้า class shape แบบนี้หมายความว่า คนที่ extend มันไปใช้ จะต้องมีฟังก์ชั่นนี้ กล่าวคือ ไม่ค้อง implement fn (e.g. return somevalue ) นี้ก่อนนำมาใช้งาน
    {
        public double Width { get; }  // get เอาค่าไปใช้ได้เท่านั่้น แก้ไขค่าไม่ได้

        public double Height { get; }  // get เอาค่าไปใช้ได้เท่านั่้น แก้ไขค่าไม่ได้

        public shape(double width, double height) //constructor fn : fn ชื่อเดียวกับ class จะถูกเรียกเมื่อตอน new object
        {
            Width = width;
            Height = height;
        }

        public abstract double GetArea(); // แม่บอกแค่ว่า ลูก"ทุกคน" ต้องมีคุณสมบัตินี้ ไม่ได้ specific ไปว่ามี อย่างไร -- บอกว่าต้องมี ไปหาวิธีมา
        
        // abstract คือยังไม่รู้ว่าจะทำยังไง -- > ใส่ abstract ที่ class ด้วย
        // ใส่ abstract เราจะประกาศแค่ชื่อ fn เฉย ๆ ได้
       
    }
}
