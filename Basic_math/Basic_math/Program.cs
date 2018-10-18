using System;


namespace Basic_math
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplied by 50
            Console.WriteLine("Enter a number");
            int userNumber0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(50 * userNumber0);

            //Adds 25
            //Console.WriteLine("Enter another number");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(25 + userNumber1);

            //Divided by 12.5
            Console.WriteLine("Enter another number");
            int userNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userNumber2 / 12.5);

            //Check if greater than 50
            Console.WriteLine("Enter another number");
            int userNumber3 = Convert.ToInt32(Console.ReadLine());
            bool greaterThan50 = 50 < userNumber3;
            Console.WriteLine(greaterThan50);

            //Modulus 7
            Console.WriteLine("Enter one more number");
            int userNumber4 = Convert.ToInt32(Console.ReadLine());
            int remainder = userNumber4 % 7;
            Console.WriteLine(remainder);


            Console.Read();
        }
    }
}
