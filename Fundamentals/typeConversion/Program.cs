//https://www.tutorialspoint.com/csharp/csharp_type_conversion.htm
//Type conversion: converting on type of data to another type
//Implicit type conversion - performed by c# automatically
//smaller to larger integer types
//conversions from derived classes to base classes

//Explicit type conversion - performed by users using pre-defined functions. These require a cast operator.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeConversion
{
    class explicitConversion
    {
        public static void callExplicitConvert()
        {
            double d = 5673.74;
            int i;

            //case double to int.
            i = (int)d;
            Console.WriteLine("casting double: {0} to int: {1}", d, i);
        }
    }

    class stringConversion
    {
        public static void callConvertStrings()
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine("Converting int {0} to string", i);
            Console.WriteLine("Converting float {0} to string", f);
            Console.WriteLine("Converting double {0} to string", d);
            Console.WriteLine("Converting bool {0} to string", b);
        }
    }
    class typeConversion
    {
        static void Main(string[] args)
        {
            explicitConversion.callExplicitConvert();
            stringConversion.callConvertStrings();
            Console.ReadKey();
        }
    }
}
