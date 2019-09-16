//https://www.tutorialspoint.com/csharp/csharp_methods.htm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    //Elements of a method:
    //Access specifier - determines visiblity of a variable or a method from another class (public, private, internal)
    //Return type - what value is returned, if any.
    //Method name
    //Parameter list ()
    //Method body
    class example
    {
        public class numberManipulator
        {
            public int findMax(int num1, int num2)
            {
                int result;

                if (num1 > num2)
                {
                    result = num1;
                }
                else
                {
                    result = num2;
                }

                return result;
            }
        }
    }

    class callingMethods
    {

    }

    class recursiveMethods
    {
        public int Factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }
    }

    class methodProgram
    {
        static void Main(string[] args)
        {
            int int1 = 0;
            int int2 = 0;
            int factorialInput = 0;
            int factorialOutput = 0;

            example.numberManipulator i = new example.numberManipulator();
            Console.WriteLine("Input first integer to compare: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer to compare: ");
            int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("max value is: " + i.findMax(int1, int2));


            Console.WriteLine("Input number for factorial calculation: ");
            factorialInput = Convert.ToInt32(Console.ReadLine());
            recursiveMethods rm = new recursiveMethods();
            factorialOutput = rm.Factorial(factorialInput);
            Console.WriteLine("factorial output: " + factorialOutput);
            Console.WriteLine("Press enter to close.");
            Console.Read();
        }
    }
}
