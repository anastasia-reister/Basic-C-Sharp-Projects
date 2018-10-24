using System;


namespace Abstract_Person_Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp2 = new Employee();
            emp2.firstName = "Jim";
            emp2.lastName = "Halpert";
            emp2.Id = 222;

            Employee emp1 = new Employee();
            emp1.firstName = "James";
            emp1.lastName = "Halpert";
            emp1.Id = 111;
            emp2.SayName();

            if (emp1 == emp2)
            {
                Console.WriteLine(emp1.firstName + " " + emp1.lastName + " and " + emp2.firstName
                    + " " + emp2.lastName + " are indeed the same person!");
            }
            else if (emp1 != emp2)
            {
                Console.WriteLine(emp1.firstName + " " + emp1.lastName + " and " + emp2.firstName
                    + " " + emp2.lastName + " are different people!");
            }

            Console.Read();


            IQuittable obj1 = new Employee(); //Not sure I understand. Does that mean obj1 is being instantiated from 
            //Employee class but is considered to be an IQuittable type?
            //Is there any difference between Interface and abstract Class besides that first one allows multiple inheritance?
            //Why interface cannot be instantiated?
            obj1.Quit();


            
        }
    }
}
