using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Oct_22_Academy01_Area_Calc
{
    internal class Triangle : shape
    {
        public Triangle (double width, double height) : base(width, height)// ไม่ add ข้างบนจะแดง
        {

        }
        public override double GetArea()               // override คือการขออนุญาตโปรแกรมเขียนทับ (overwrite ) ฟังก์ชันเดิมของ Class แม่ เวลาดูข้อผิดพลาดจะได้ recheck กลับไปที่ class แม่ด้วย
        {


            return 0.5 * Width * Height;        //
        }
    }
}
