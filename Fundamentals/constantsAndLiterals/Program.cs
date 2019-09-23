//https://www.tutorialspoint.com/csharp/csharp_constants.htm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constantsAndLiterals
{
    class integerLiterals
    {
        //integer literals can be decimal or hexadecimal
        //examples: 212, 215u, 0xFeeL
        //85, decimal
        //0x4b, hexadecimal
        //30, int
        //30u, unsigned int
        //30l, long
        //30ul, unsigned long
    }

    class floatLiterals
    {
        //floating-point literals has an integer, decimal, fractional, or exponent part
        //can be represented as decimal or exponential form
        //3.14159, decimal
        //314159E-5F, exponential
    }

    class characterConstants
    {
        //enclosed in single quotes
        //'x' can be stored as CHAR
        //Other options include escapt sequences '\t' and universal characters '\u02C0'
        //        \\ 	\ character
        //\' 	' character
        //\" 	" character
        //\? 	? character
        //\a Alert or bell
        //\b Backspace
        //\f Form feed
        //\n Newline
        //\r Carriage return
        //\t Horizontal tab
        //\v Vertical tab
        //\xhh. . .Hexadecimal number of one or more digits
        public static void callEscapeChar()
        {
            Console.WriteLine("Hello\tWorld\n\n");
        }

    }

    class stringLiterals
    {
        //enclosed in double quotes
    }

    class definingConstants
    {
        public static void declareConst()
        {
            const double pi = 3.14159;

            double radius;
            Console.WriteLine("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * radius * radius;
            Console.WriteLine("Radius: {0}, Area: {1}", radius, areaCircle);
            Console.Read();
        }
    }
    class constantsLiteralsProgram
    {
        static void Main(string[] args)
        {
            characterConstants.callEscapeChar();
            definingConstants.declareConst();
        }
    }
}
