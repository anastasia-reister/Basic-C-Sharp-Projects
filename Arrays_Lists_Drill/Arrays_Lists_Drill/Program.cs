using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        string[] futurama = new string[6] { "Philip J. Fry,", "Bender", "Morbo", "Zoidberg", "Nibbler", "Hypnotoad" };
    Pick_a_futnumber:
        Console.WriteLine("Pick a number from 0 to 5");
        int number = Convert.ToInt16(Console.ReadLine());
        if (number >= 0 && number < 6)
        {
            Console.WriteLine("Your spiritual animal is " + futurama[number]);
        }
        else
        {
            Console.WriteLine("You didn't pick a number from 0 to 5");
            goto Pick_a_futnumber;
        }


        int[] fibNumbers = new int[10] { 0, 3, 67, 2, 8, 5, 90, 13, 21, 34 };
    Pick_a_fibnumber:
        Console.WriteLine("Pick a number from 1 to 10");
        int fibNum = Convert.ToInt16(Console.ReadLine()) - 1;
        if (fibNum >= 0 && fibNum < 10)
        {
            Console.WriteLine("You have " + fibNumbers[fibNum] + " lives.");
        }
        else
        {
            Console.WriteLine("You didn't pick a number from 1 to 10");
            goto Pick_a_fibnumber;
        }

        List<string> bobsBurgers = new List<string>();
        bobsBurgers.Add("Bob");
        bobsBurgers.Add("Linda");
        bobsBurgers.Add("Tina");
        bobsBurgers.Add("Gene");
        bobsBurgers.Add("Louise");
        Pick_a_bobnumber:
        Console.WriteLine("Please select a number from 1 to 5:");
        int bobNum = Convert.ToInt16(Console.ReadLine())- 1;
        if (bobNum >= 0 && bobNum < 5)
        {
            Console.WriteLine("In Bob's Burgers you would be a " + bobsBurgers[bobNum] + "!");
        }
        else
        {
            Console.WriteLine("You didn't pick a number from 1 to 5");
            goto Pick_a_bobnumber;
        }
        


        Console.Read();


      
        }
    }

