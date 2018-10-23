using System;

namespace page113_methods_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            moreMath math1 = new moreMath(); //instatiation of the class

            moreMath.sampleMethod(first: 2, second: 3); //calling method; would not call method of instance since is a static method

            Console.Read();

            
        }
    }
}
