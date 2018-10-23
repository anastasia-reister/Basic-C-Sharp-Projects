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
            string stringNum1 = Console.ReadLine();

            Console.WriteLine("Enter another number or press enter");
            string  stringNum2 = Console.ReadLine();
            //Console.Read();

            //5. Try various combinations of numbers on the code, including having no second number.
            // This if statement evaluates if second inout was a number, if so converts it to int and calls method with 2 parameters
            // if second inout is not a number - a letter or return key, call method with 1 param, second is default.
            int num2;
            if (!int.TryParse(stringNum2, out num2))  // second passed string is NOT an integer
            {
                int num1 = Convert.ToInt32(stringNum1);
                Console.WriteLine("method with one parameter specified: " + someMath1.multiply(first: num1));
            }
            else
            {
                int num1 = Convert.ToInt32(stringNum1);
                num2 = Convert.ToInt32(stringNum2);
                Console.WriteLine("method with both parameters specified: " + someMath1.multiply(first: num1, second: num2));
            }
            Console.Read();

        }
    }
}
