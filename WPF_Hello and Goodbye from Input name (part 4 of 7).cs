using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Oct_22_Academy02
{
    internal class FriendlyGreeter : IGreeter , IFarewell , IGreeterAndFarewell
    {
        public string Farewell(string name)
        {
            return $"Bye {name} !";
        }




        public string Greet(string name)
        {
            return $"Hi {name} !";
        }
    }
}
