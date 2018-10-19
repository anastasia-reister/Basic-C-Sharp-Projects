using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "I ";
            string b = "love ";
            string c = "tacos!";

            Console.WriteLine(a + b + c.ToUpper());
            

            StringBuilder paragraph = new StringBuilder(50);
            paragraph.AppendLine("There were a king with a large jaw and a queen with a plain face, on the throne of England");
            paragraph.AppendLine("There were a king with a large jaw and a queen with a fair face, on the throne of France.");
            paragraph.AppendLine("In both countries it was clearer than crystal to the lords of the State preserves of loaves and fishes, that things in general were settled for ever.");
            paragraph.AppendLine("It was the year of Our Lord one thousand seven hundred and seventy - five. ");
            paragraph.AppendLine(" Spiritual revelations were conceded to England at that favoured period, as at this.");

            Console.WriteLine(paragraph);

            Console.Read();
        }
    }
}
