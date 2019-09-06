//A variable is nothing but a name given to a storage area that our programs can manipulate.Each variable in C# has a specific type, 
//which determines the size and layout of the variable's memory the range of values that can be stored within that memory and the set of operations that can be applied to the variable.

//The basic value types provided in C# can be categorized as −

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class definingVariables
    {
        public static void defineVariable()
        {
            int i, j, k;
            char c, ch;
            float f, salary;
            double d;

            Console.WriteLine("defined ints, chars, float, and doubles.");
        }
    }

    class initializingVariables
    {
        public static void initializeVariables()
        {
            int d = 3, f = 5;
            byte z = 22;
            double pi = 3.14159;
            char x = 'x';
            Console.WriteLine("int d: {0}, int f: {1}, byte z: {2}, double pi: {3}, char x: {4}", d, f, z, pi, x);
        }
    }

    class acceptingValuesFromUser
    {
        public static void acceptValuesFromUser()
        {
            Console.WriteLine("Please input an integer.");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input from user {0}", num);
        }
    }

    class LvalueAndRValue
    {

    }
    class variableProgram
    {
        static void Main(string[] args)
        {
            definingVariables.defineVariable();
            initializingVariables.initializeVariables();
            acceptingValuesFromUser.acceptValuesFromUser();
            Console.Read();
        }
    }
}
