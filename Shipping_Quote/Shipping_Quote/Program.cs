using System;
using System.Globalization;


namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package WEIGHT:");
            float weight = float.Parse(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via PAckage Express. Have a good day.");
            } else {
                Console.WriteLine("Please enter the package WIDTH:");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the package HEIGHT:");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the package LENGTH:");
                float length = float.Parse(Console.ReadLine());
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                } else
                {
                    float quote = ((width + height + length) * weight) / 100;
                    Console.WriteLine(quote.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    Console.Read();
                }
            }
        }
    }
}
