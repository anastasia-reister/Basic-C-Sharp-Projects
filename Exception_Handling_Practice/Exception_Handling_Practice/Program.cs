using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        //Q 1. Create a list of integers. Ask the user for a number to divide each number
        //in the list by. Write a loop that takes each integer in the list, divides it by the number 
        //the user entered, and displays the result to the screen.
        try
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Enter a number");
            int divider = Convert.ToInt32(Console.ReadLine());

            foreach (int number in numbers)
            {
                int result = number / divider;
                Console.WriteLine("Result is " + result);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("The program has emerged from the try/catch block");
        Console.Read();
    }
    }

