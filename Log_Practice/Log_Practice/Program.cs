using System;
using System.IO;

namespace Log_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers.");
            int i = 0;
            do
            {
                i++;
                Console.WriteLine("Enter a number " + i + ": ");
                string number = Console.ReadLine();
                using (StreamWriter numberLog = new StreamWriter(@"C:\Users\Nastya\Documents\GitHub\Basic-C-Sharp-Projects\Log_Practice\numberLog.txt", true))
                {
                    numberLog.WriteLine(number);
                }
            }while( i < 5) ;

            string numberLogString = File.ReadAllText(@"C:\Users\Nastya\Documents\GitHub\Basic-C-Sharp-Projects\Log_Practice\numberLog.txt");
            Console.WriteLine("Numbers that have been entered: " + numberLogString);
            Console.Read();
        }
    }
}
