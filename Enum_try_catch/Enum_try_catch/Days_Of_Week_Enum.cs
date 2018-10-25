using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_try_catch
{
    

    class Days_Of_Week_Enum 
    {

        public static T ParseEnum<T>(string value) //found on Stack Overflow
        {
            return (T)Enum.Parse(typeof(T), value, ignoreCase: true);
        }
    }

    public enum DayOfWeek  //1. Create an enum for the days of the week.
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
