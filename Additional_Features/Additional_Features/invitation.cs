using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    public class Invitation
    {
        public string Name { get; set; }
        public string Event { get; set; }
        public DateTime Date { get; set; }
        public  Invitation(string name1, string eventName, DateTime date)
        {
            Name = name1;
            Event = eventName;
            Date = date;
            Console.WriteLine (" Dear {0}, \n Please join us for the celebration of \n {1} \n on \n {2}", name1, eventName, Convert.ToString(date));
        }

        public  Invitation(string eventName, DateTime date): this( "guest", eventName, date)
        {

        }
    }
}
