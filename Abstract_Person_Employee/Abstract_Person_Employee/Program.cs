using System;


namespace Abstract_Person_Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> emp3 = new Employee<string>();
            emp3.firstName = "James";
            emp3.lastName = "Halpert";
            emp3.Id = 111;
            

            Employee<string> emp2 = new Employee<string>();
            emp2.firstName = "Dwight";
            emp2.lastName = "Schrute";
            emp2.Id = 222;
            emp2.Things.Add("bears");
            emp2.Things.Add("beets");
            emp2.Things.Add("battlestar galactica");

            Employee<int> emp1 = new Employee<int>();
            emp1.firstName = "Dwigt";
            emp1.lastName = "Schrute";
            emp1.Id = 111;
            emp1.Things.Add(1);
            emp1.Things.Add(2);
            emp1.Things.Add(3);

            Console.WriteLine(emp2.firstName + " " + emp2.lastName);
            foreach (string thing in emp2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine(emp1.firstName + " " + emp1.lastName);
            foreach (int thing in emp1.Things)
            {
                Console.WriteLine(thing);
            }


            emp2.SayName();

            if (emp3 == emp2)
            {
                Console.WriteLine(emp3.firstName + " " + emp3.lastName + " and " + emp2.firstName
                    + " " + emp2.lastName + " are indeed the same person!");
            }
            else if (emp3 != emp2)
            {
                Console.WriteLine(emp3.firstName + " " + emp3.lastName + " and " + emp2.firstName
                    + " " + emp2.lastName + " are different people!");
            }

            Console.Read();


            IQuittable obj1 = new Employee<string>(); //Not sure I understand. Does that mean obj1 is being instantiated from 
            //Employee class but is considered to be an IQuittable type?
            //Is there any difference between Interface and abstract Class besides that first one allows multiple inheritance?
            //Why interface cannot be instantiated?
            obj1.Quit();


            
        }
    }
}
