using System;


namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //Numbers for Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly rate");
            float hourlyR1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week");
            float hours1 = float.Parse(Console.ReadLine());

            //Number for Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly rate");
            float hourlyR2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week");
            float hours2 = float.Parse(Console.ReadLine());

            //Annual salary P1
            Console.WriteLine("Annual salary of Person 1:");
            float annualP1 = 52 * hourlyR1 * hours1;
            Console.WriteLine(annualP1);

            //Annual salary P2
            Console.WriteLine("Annual salary of Person 2:");
            float annualP2 = 52 * hourlyR2 * hours2;
            Console.WriteLine(annualP2);

            //Comapre P1 and P2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool p1MoreThanP2 = annualP1 > annualP2;
            Console.WriteLine(p1MoreThanP2);

            Console.Read();
        }
    }
}
