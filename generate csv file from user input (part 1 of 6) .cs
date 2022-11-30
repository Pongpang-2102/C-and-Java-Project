using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Oct_22_Academy_csv_process
{
    interface IemailGenerator
    {
        EmailRecord Generate (string firstname , string lastname , int year , string email, DateTime? birthDate) ;
        
        
        
        
    }
}
