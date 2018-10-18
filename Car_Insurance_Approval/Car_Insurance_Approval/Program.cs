using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval
{
    class Program
    {
        static void Main(string[] args)
        {
            //Applicant info input
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTix = Convert.ToInt16(Console.ReadLine());

            //Evaluation
            bool qualify = (age > 15 && (dui == "no"|| dui =="No") && speedingTix <= 3);
            Console.WriteLine(qualify);
            Console.Read();


        }
    }
}
