//https://www.tutorialspoint.com/csharp/csharp_data_types.htm
//The variables in C#, are categorized into the following types −

//    Value types
//    Reference types
//    Pointer types

//Value types:
//bool      Boolean value True or False   False
//byte 	    8-bit unsigned integer 	0 to 255 	0
//char 	    16-bit Unicode character U +0000 to U +ffff 	'\0'
//decimal 	128-bit precise decimal values with 28-29 significant digits(-7.9 x 1028 to 7.9 x 1028) / 100 to 28 	0.0M
//double 	64-bit double-precision floating point type(+/-)5.0 x 10-324 to(+/-)1.7 x 10308 	0.0D
//float 	32-bit single-precision floating point type     -3.4 x 1038 to + 3.4 x 1038 	0.0F
//int 	    32-bit signed integer type  -2,147,483,648 to 2,147,483,647 	0
//long 	    64-bit signed integer type  -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 	0L
//sbyte 	8-bit signed integer type   -128 to 127 	0
//short 	16-bit signed integer type  -32,768 to 32,767 	0
//uint 	    32-bit unsigned integer type    0 to 4,294,967,295 	0
//ulong 	64-bit unsigned integer type    0 to 18,446,744,073,709,551,615 	0
//ushort 	16-bit unsigned integer type    0 to 65,535 	0

//Reference types
//Reference types do not contain the actual data stored in a variable, but they do contain a reference to the variables.
//Refer to memory location
//Types of reference variables:
// object
//Objects are a base class that can be assigned any value, but must be converted before assigning a value.
//when a value type is converted to an object, it is called boxing.
//when a object type is converted into a value type, it is called unboxing.
//Type checking is determined at compile time.

//dynamic
//any type of value can be stored in a dynamic variable, and the type checking is determined at run time.
//string
//assigned as one of two types: quoted or @quoted.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataType
{
    class DataTypeApplication
    {
        static void Main(string[] args)
        {
            //Object Type Testing
            object obj;
            obj = 100;//boxing
            int iObject = Convert.ToInt32(obj);//unboxing
            Console.WriteLine("Boxed object variable value: {0}", obj);
            Console.WriteLine("Unboxed object variable value: {0}", iObject);
            //Dynamic variable testing
            dynamic d = 20;
            Console.WriteLine("Dynamic variable value: {0}", d);
            //String type testing
            String str = "Hello world!";
            //Pointer type testing, not usable normally.
            //char* cptr;
            //int* iptr;
            Console.WriteLine("String variable value: {0}", str);
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.ReadLine();
        }
    }
}
