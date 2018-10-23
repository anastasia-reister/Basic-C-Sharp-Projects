using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            someMath someMath1 = new someMath(); //2. In the Main() method of the console app, instantiate the class.


            //3. Ask the user to input two numbers, one at a time. 
            //Let them know they need not enter anything for the second number. -- not sure 
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //5. Try various combinations of numbers on the code, including having no second number.
            Console.WriteLine("method with one parameter specified: " + someMath1.multiply(num1));

            Console.WriteLine("method with both parameters specified: " + someMath1.multiply(num1,num2));

            Console.Read();

        }
    }
}
