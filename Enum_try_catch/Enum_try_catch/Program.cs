using System;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                try //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
                {
                    i++;
                    Console.WriteLine("Please enter current day of the week: "); //2. Prompt the user to enter the current day of the week.
                    string todayStr = Console.ReadLine();
                    DayOfWeek today = Days_Of_Week_Enum.ParseEnum<DayOfWeek>(todayStr); //3. Assign the value to a variable of that enum data type you just created.
                    Console.WriteLine(today);
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week!");
                }

            } while (i < 5); //just to be able to try different options at once
            Console.Read();

        }
    }
}
