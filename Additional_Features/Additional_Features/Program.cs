using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CompanyName = "Custom Invitations";
            Console.WriteLine("Welcome to {0}", CompanyName);
            Console.WriteLine("What is the name of your event?");
            string eventName = Console.ReadLine();
            Console.WriteLine("What is the date and time of your event? (Please format as mm dd yyyy)");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            var invitation1 = new Invitation(eventName, date);
            
            Console.Read();
           
        }
    }
}
