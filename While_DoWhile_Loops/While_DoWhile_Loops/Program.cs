using System;


namespace While_DoWhile_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number lower than 25");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---");
            int initNum = number;
            while (number < 25)
            {
                Console.WriteLine(number);
                number++;
            }

            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number >= initNum);

            Console.Read();
        }
    }
}
