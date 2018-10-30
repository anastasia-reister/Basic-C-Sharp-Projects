using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAge = false;

            while (!validAge)
            {
                try
                {
                
                    Console.WriteLine("Please enter your age:");
                    int age;
                    validAge = int.TryParse(Console.ReadLine(), out age);
                    if (!validAge)
                    {
                        Console.WriteLine("Has to be a whole number");
                        
                    }
                    else if (age == 0)
                    {
                        throw new TooYoung();
                    }
                    else if (age < 0) throw new NegativeAge();
                    else
                    {

                        Console.WriteLine("You were born in year " + (Convert.ToInt32(DateTime.Now.Year) - age));
                        Console.Read();
                    }
                
                }
                catch (TooYoung)
                {
                    Console.WriteLine("You're to young to be able to type.");
                    validAge = false;
                    
                
                }
                catch (NegativeAge)
                {
                    Console.WriteLine("You entered negative age. Does not compute.");
                    validAge = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong. Try Again.");
                    validAge = false;

                }
            }


        }
    }
}
