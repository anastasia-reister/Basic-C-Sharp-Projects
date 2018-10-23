using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            maths math1 = new maths();//2. In the Main() method, instantiate that class.
            Console.WriteLine("Enter a number you would like to divide by 2");
            int number = Convert.ToInt32(Console.ReadLine());//3. Have the user enter a number. 
            math1.divideByTwo(number, out float divided);//Call the method on that number. 
            Console.WriteLine("Our calculation show that result is " + divided + "\n"); //Display the output to the screen. It should be the entered number, divided by two.

            Console.WriteLine("Enter a word you would like to divide in two");
            string word = Console.ReadLine();
            math1.divideByTwo(word, out string half1, out string half2);
            Console.WriteLine("Succes! You made two new words: " + half1 + " and " + half2 + ". Use them wisely. \n");


            Console.WriteLine("Harris-Benedict Formula of Basal Metabolic Rate.\n");
            Console.WriteLine("Please enter \"m\" for male or \"f\" for female");
            string gender = Console.ReadLine();

            Console.WriteLine("Please enter weight in pounds:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter height in inches:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter age in years");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please evaluate your activity level from 1 to 5, 1 being Sedentary and 5 being Extra active");
            int actFact = Convert.ToInt16(Console.ReadLine());

            BMR.CaloricCount(gender, weight, height, age, actFact, out double calC);
            Console.WriteLine("According to Harris-Benedict Formula of Basal Metabolic Rate your daily caloric intake to maintain weight is " + calC + " calories.");
            Console.Read();
        }
    }
}
