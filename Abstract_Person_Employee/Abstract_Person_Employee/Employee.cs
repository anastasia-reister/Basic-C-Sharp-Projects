using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Person_Employee
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: [" + firstName + " " + lastName + "]");
        }

        public void Quit()
        {
            Console.WriteLine("I Quit!");
        }

        public static bool operator==(Employee emp1, Employee emp2)
        {
            bool isEqual = false;
            if(emp1.Id == emp2.Id)
            {
                isEqual = true;
            }
            return isEqual;
        }

        public static bool operator!=(Employee emp1, Employee emp2)
        {
            bool isNotEqual = false;
            if (emp1.Id != emp2.Id)
            {
                 isNotEqual = true;
            }
            return isNotEqual;
        }


    }
}
