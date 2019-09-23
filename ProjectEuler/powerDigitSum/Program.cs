

//215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

//What is the sum of the digits of the number 21000?



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace powerDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int iBase = 2;
            int iPower = 50;
            decimal dResult = 1;
            string sResult = "";
            char[] cArray;
            decimal dOutput = 0;

            dResult = Convert.ToDecimal(Math.Pow(iBase, iPower)); //Calculate iBase to the power of iPower
            Console.WriteLine("dResult: " + dResult);
            
            

            //convert dResult into string, and split into individual characters. Put in int array.
            sResult = dResult.ToString();
            sResult = Decimal.Parse(sResult, System.Globalization.NumberStyles.Any).ToString();
            Console.WriteLine("dResult: " + dResult);


            cArray = new char[sResult.Length];
            cArray = sResult.ToCharArray();

            for (int i = 0; i < cArray.Length; i++)
            {
                Console.WriteLine("Adding " +  cArray[i].ToString() + " to " + dOutput);


                dOutput = dOutput + Decimal.Parse(cArray[i].ToString());
                Console.WriteLine("char: " + cArray[i] + "dOutput: " + dOutput);
            }

            
            Console.ReadLine();
        }
    }
}
