//https://www.tutorialspoint.com/csharp/csharp_arrays.htm
using Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Multi-dimensional arrays:two-dimensional array
//Jagged array:
//arrays can be passed as parameters
//
namespace Arrays
{
    //fixed-size collection of elements of the same type
    //declare one array variable instead of individual parts datatype [] arrayName

    public class declareArrays
    {
        //declare
        public static double[] balance = new double[10]; 

        public class initializeArray
        {
            public static void InitializeArray()
            {
                //set values individually
                balance[0] = 4500;
                balance[9] = 999;

                Console.WriteLine("balance[0]: {0}", balance[0]);
                Console.WriteLine("balance[9]: {0}", balance[9]);
            }
        }
    }

    

    class assignValueToArray
    {
        //set value at runtime
        public static double[] balance3 = { 2340.0, 4523.69, 3421.0 };
        //set value at runtime with declared size
        public static int[] marks = new int[5] { 99, 98, 92, 97, 95 };
        //set value at runtime with non-declared size
        public static int[] marks2 = new int[] { 99, 98, 92, 97, 95 };
    }

    class accessArray
    {
        public static void outputArray()
        {
            int[] n = new int[10];
            int i, j;

            //initialize array
            for (i=0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            //output array elements
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.WriteLine("Press enter to continue:");
            Console.ReadKey();
        }
    }


    class forEachLoop
    {

    }


    class arraysProgram
    {
        static void Main(string[] args)
        {
            declareArrays.initializeArray.InitializeArray();
            accessArray.outputArray();
        }
    }
}


