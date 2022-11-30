using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Oct_22_Academy02
{
    // creating class FormalGreeter with Main IGreter 
    internal class FormalGreeter : IGreeter,IFarewell,IGreeterAndFarewell
    {
        public string Farewell(string name)
        {
            return $"Good Bye {name}";
        }

        public string Greet(string name)
        {
            return $"Hello {name}";
        }
    }
}
