using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Oct_22_Academy01_Area_Calc
{
    internal class Elipse : shape // สร้าง class โดย quick action มันจะ generate ตัว get area ให้
    {
        public Elipse(double width, double height) : base(width, height)
        {


        }
        public override double GetArea()               // override คือการขออนุญาตโปรแกรมเขียนทับ (overwrite ) ฟังก์ชันเดิมของ Class แม่ เวลาดูข้อผิดพลาดจะได้ recheck กลับไปที่ class แม่ด้วย
        {
            return Math.PI * Width * Height;

                   //
        }
    }
}
