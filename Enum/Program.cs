//https://www.tutorialspoint.com/csharp/csharp_enums.htm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    //Enumerator -> a set of named integer constants
    //Cannot inherit or pass inheritance
    //each symbol in the enumeration list stands for an integer value, one greater than than the symbol that precedes it.
    //by default, the value of the first symbol = 0;
    class EnumExample
    {
        enum Days {Sun, Mon, Tue, Wed, Thu, Fri, Sat};

        public static void EnumOutput()
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);

            //iterate through enum, because I was curious.
            foreach (Days x in Days.GetValues(typeof(Days)))
            {
                Console.WriteLine("Enum value: {0}", x);
            }
        }
    }

    class EnumsProgram
    {
        static void Main(string[] args)
        {
            EnumExample.EnumOutput();
            Console.ReadLine();
        }
    }
}
