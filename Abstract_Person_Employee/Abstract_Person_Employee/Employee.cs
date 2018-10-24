using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Person_Employee
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: [" + firstName + " " + lastName + "]");
        }
    }
}
