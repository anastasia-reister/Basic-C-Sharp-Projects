using System;
using System.Collections.Generic;


namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //Q1
            string[] textInput = new string[6] { "1.", "2.", "3.", "4.", "5.", "6." };
            for (int i = 0; i < textInput.Length; i++)
            {
                if (i < 1)
                {
                    Console.WriteLine("Tell me a joke.");
                }
                else
                {
                    Console.WriteLine("Tell me another joke");
                }
                textInput[i] = Console.ReadLine();
            }
            Console.WriteLine("\n So, these are your jokes:");
            for (int j = 0; j < textInput.Length; j++)
            {
                Console.WriteLine(textInput[j]);
            }


            //Q2

            //for(; ; )
            //{
            //    Console.WriteLine(1);
            //}
            Console.WriteLine("\n Loop made finite ");
            for (int i = 0; i < 10 ; i++ )
            {
                Console.WriteLine(1);
            }


            //Q4 Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            Console.WriteLine("\n Here are all the jokes again: (<)");
            for (int a = 0; a < textInput.Length; a++)
            {
                Console.WriteLine(textInput[a]);
            }

            //Q5 Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            Console.WriteLine("\n One more time: (<=)");
            for (int x = 0; x <= textInput.Length - 1; x++)
            {
                Console.WriteLine(textInput[x]);
            }

           //Q6 Create a List of strings where each item in the list is unique.Ask the user to select text to search for 
           //in the List.Create a loop that iterates through the list and then displays the index of the array that contains 
           //matching text on the screen.

           List<string> rainbowColors = new List<string>();
           rainbowColors.Add("red");
           rainbowColors.Add("orange");
            rainbowColors.Add("yellow");
            rainbowColors.Add("green");
            rainbowColors.Add("blue");
            rainbowColors.Add("indigo");
            rainbowColors.Add("violet");

            Console.WriteLine("Tell me your favorite color:");
            string favcolor = Console.ReadLine();
            favcolor = favcolor.ToLower();
            bool colorFound = false;
            for (int b = 0; b < rainbowColors.Count; b++)
            {
                if (rainbowColors[b] == favcolor)
                {
                    Console.WriteLine("Your favorite color is # " + (b + 1) + " in the rainbow.");
                    colorFound = true;
                    break; //Q8 Add code to that above loop that stops it from executing once a match has been found.

                }

            }
            //7. Add code to that above loop that tells a user if they put in text that isn’t in the List.

            if (colorFound == false)
            {
                Console.WriteLine("No such color!");
            }

            //Q9. Create a List of strings that has at least two identical strings in the List. 
            //Ask the user to select text to search for in the List. Create a loop that iterates 
            //through the list and then displays the indices of the array that contain matching text on the screen.
            List<string> waitlist = new List<string>();
            waitlist.Add("Jeff");
            waitlist.Add("George");
            waitlist.Add("Lana");
            waitlist.Add("Ashley");
            waitlist.Add("Paul");
            waitlist.Add("Rita");
            waitlist.Add("Paul");

            Console.WriteLine("What was your name on the waitlist?");
            string waitlistName = Console.ReadLine();
            waitlistName = waitlistName.ToLower();
            bool found = false;

            for (int d = 0; d < waitlist.Count; d++)
            {
                if (waitlist[d].ToLower() == waitlistName)
                {
                    Console.WriteLine("Hi " + waitlist[d] + "! You are #" + d + " on our list!");
                    found = true;
                }
            }

            //Q 10. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            if (found == false) 
            {
                Console.WriteLine("Sorry you're not on our list!");
            }

            //Q 11.Create a List of strings that has at least two identical strings in the List. 
            //Create a foreach loop that evaluates each item in the list, and displays a message showing the 
            //string and whether or not it has already appeared in the list.

            int counter = 0;
                foreach(string name in waitlist)
                {
                    Console.WriteLine("Hi " + name +"!");
                    counter++;
                    if (waitlist.IndexOf(name)+1 < counter)
                    {
                        Console.WriteLine(name + " already exists!");
                    }
               
                }

            Console.Read();
        }
    }
}
