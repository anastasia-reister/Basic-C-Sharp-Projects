using System;


namespace Abstract_Person_Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp2 = new Employee();
            emp2.firstName = "Sample";
            emp2.lastName = "Student";

            emp2.SayName();


            IQuittable obj1 = new Employee(); //Not sure I understand. Does that mean obj1 is being instantiated from 
            //Employee class but is considered to be an IQuittable type?
            //Is there any difference between Interface and abstract Class besides that first one allows multiple inheritance?
            //Why interface cannot be instantiated?
            obj1.Quit();


            Console.Read();
        }
    }
}
