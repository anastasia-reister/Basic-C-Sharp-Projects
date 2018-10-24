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
            Console.Read();
        }
    }
}
