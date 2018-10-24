using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Person_Employee
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: [" + firstName + " " + lastName + "]");
        }

        public void Quit()
        {
            Console.WriteLine("I Quit!");
        }
    }
}
