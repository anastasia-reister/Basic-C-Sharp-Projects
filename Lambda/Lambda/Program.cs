using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. In the Main() method, create a list of at least 10 employees. 
            //Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".


            List<Employee> empList = new List<Employee>();
            
            List<string> fNames = new List<string>() { "Alex", "Megan", "Bill", "Joe", "Jill", "Sandra", "Joe", "Rio", "Tiffany", "Jack" };
            List<string> lNames = new List<string>() { "Jackson", "Rubio", "Johnes", "Cole", "Nevada", "Kachinsky", "Martin", "Hale", "Pine", "Roberts" };
        

            for (int i =0; i < 10; i++)
            {
                Employee emp = new Employee();
                emp.FName = fNames[i];
                emp.LName = lNames[i];
                emp.Id = i+1;
                empList.Add(emp);
            }

          

            //2. Using a foreach loop, create a new list of all employees with the first name "Joe".

            List<Employee> Joes = new List<Employee>();

            //foreach ( Employee employee in empList)
            //{
            //    if (employee.FName == "Joe")
            //    {
            //        Joes.Add(employee);
            //    }
            //}

            //3. Do the same thing again, but this time with a lambda expression.

            Joes = empList.Where(x => x.FName == "Joe").ToList();

            //4. Using a lambda expression, make a list of all employees with an Id number greater than 5

            List<Employee> Over5 = empList.Where(x => x.Id > 5).ToList();


            Console.WriteLine("Employees with first name  - Joe \n");
            foreach (Employee emp in Joes)
            {
                Console.WriteLine(emp.LName);
            }

            Console.WriteLine("\nEmployees with ID greated than 5: \n");
            foreach (Employee emp in Over5)
            {
                Console.WriteLine(emp.FName + " " + emp.LName + " " + emp.Id);
            }
            Console.Read();
        }
    }
}
