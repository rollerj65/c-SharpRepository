
//https://www.tutorialspoint.com/csharp/csharp_nullables.htm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    //nullable values can be assigned normal values, as well as null

    class calculatorApplication
    {
        public static void declareNullable()
        {
            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolVal = new bool?();

            Console.WriteLine("Nullables: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("Nullable boolean value: {0}", boolVal);
        }


        //coalescing operator will convert one type of nullable variable to another, where it can be done.
        //if fires operand is null, then it will return second operator.
        public static void nullCoalescingOperator()
        {
            double? num1 = null;
            double? num2 = 3.1457;
            double num3;

            num3 = num1 ?? 5.34;
            Console.WriteLine("Value of num3: {0}", num3);

            num3 = num2 ?? 5.34;
            Console.WriteLine("Value of num3: {0}", num3);
            Console.WriteLine("Press enter to continue.");
            Console.Read();
        }


    }

    class nullablesProgram
    {
        static void Main(string[] args)
        {
            calculatorApplication.declareNullable();
            calculatorApplication.nullCoalescingOperator();
        }
    }
}
