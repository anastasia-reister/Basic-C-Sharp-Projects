using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Person_Employee
{
    public class Person
    {
        //Properties -----------------
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }
    }
}
