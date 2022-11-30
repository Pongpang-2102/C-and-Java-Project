
// 01. basic Operation
namespace Basic_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Tony";
            int x = 3;
            int y = 7;
            double a = 1.5;
            double b = 2;
            bool vaccinated = true;
            x--; // x will be deducted by 1
            a++; // a will be increased by 1

            var result = x / a;          # var will be defined variable type automatically


            """ Say Hello to User long comments Pongpang line 1
               Say Hello to User long comments Pongpang line 2
               Say Hello to User long comments Pongpang line 3
               Say Hello to User long comments Pongpang line 4
            """

            // พิมพ์ทักทายผู้ใช้    short comment
            /*Console.WriteLine("Hello Pongpang \n" +
                               "Nice to meet you");*/

            Console.WriteLine("Hello " + name );
            Console.WriteLine("x =  " + x + 
                              "\ny = " +  y + 
                              "\nx + y = " + (x + y)  );
            Console.WriteLine(a * x);
            Console.WriteLine(vaccinated);

            // try other operators

            // Console.WriteLine(y / x); // answer = 2
            Console.WriteLine("x * y = " + (x * y)   );
            Console.WriteLine(a / b); // 1.5 / 2 answer = 0.75
            Console.WriteLine(y % x); // 7/3 = 2 เศษ 1 คำตอบคือ 1

            Console.WriteLine(result) ; // อะไรไป operated กับ double จะได้ double


        }
    }
}





