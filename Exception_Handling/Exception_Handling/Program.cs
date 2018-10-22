using System;


    class Program
    {
        
        static void Main(string[] args)
        {
        try
        {
            Console.WriteLine("Enter a number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dividing...");
            int result = n1 / n2;
            Console.WriteLine("result is " + result);

           
      
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            string errors = Console.ReadLine();//if we need to keep a record of all error messages
        }


        Console.Read();

    }
    }

