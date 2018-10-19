using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
    {

        string[] names = new string[4] { "Jesse", "Jaimie", "Adam", "Luke" };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        List<int> scores = new List<int>();
        scores.Add(99);
        scores.Add(56);
        scores.Add(96);
        scores.Add(45);
        scores.Add(87);
        scores.Add(79);

        foreach(int score in scores)//in foreach variable is the value of a list ite, not its index
        {
            if (score > 85)
            {
                Console.WriteLine("Passing grade" + score);
            }
        }


        Console.Read();
        }
    }

