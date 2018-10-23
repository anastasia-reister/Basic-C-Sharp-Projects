using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_instantiating
{
    class Program
    {
        static void Main(string[] args)
        {
            similar_methods method1 = new similar_methods(); //instantiating class similar_methods
            // not sure if I had to instantiate the class all three times I called a method since they all belong to one class. So I only did once.
            Console.WriteLine("Method that takes an int and returns an int and adds 5: " + method1.one_method(12));
            
            Console.WriteLine("Method that takes an decimal and returns an int and adds 10: " + method1.one_method(1.22m));

            Console.WriteLine("Method that takes an string and returns an int and adds 20: " + method1.one_method("12"));

            Console.Read();
        }
    }
}
