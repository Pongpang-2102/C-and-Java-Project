using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_oct_22_Customer_DB_app
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }


        public override string ToString() // display customer detail (firstname , lastname & email sequentially )
                                          // from user input (after user press add button)
        {
            return $"{FirstName} {LastName} ({Gender})"; // show record from db in form as you needed
        }


    }
}
