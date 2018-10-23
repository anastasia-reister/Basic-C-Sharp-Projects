using System;


namespace Class_Method_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int userNumber =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here is what rounded 3/4 of our number is:");
            Console.WriteLine(someMath.threeQuarters(userNumber));

            Console.WriteLine("Here is waht rounded 150% of your number is:");
            Console.WriteLine(someMath.percent150(userNumber));

            Console.WriteLine("Here is how many quarters you can get from your number of dollars:");
            Console.WriteLine(someMath.inQuarters(userNumber));

            Console.Read();
        }
    }
}
