using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, create an object of data type Number and assign an amount to it.
            Numbers number = new Numbers();
            number.Amount = 3.5m;
            Console.WriteLine(number.Amount);
            Console.Read();
        }
    }
}
