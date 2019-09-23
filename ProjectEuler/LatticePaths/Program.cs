//starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.

//How many such routes are there through a 20×20 grid?


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatticePaths
{
    class Program
    {
        static void Main(string[] args)
        {//Reference: https://codereview.stackexchange.com/questions/25419/project-euler-15-count-possible-lattice-paths. Uses permutation equation to calculate. Probably the best way.
            double iOutput = 1;
            int iSize = 20; //size of lattice
            int iMax = 40; //number of options (iSize options per valid path (right/down)
            double iMaxPermutation = iMax;
            double iPermutationDivisor = iSize;

            for (int i = 1; i < iSize + 1; i++)
            {
                iOutput = iOutput * (iMax - i) / (i + 1); 
            }
            //Console.WriteLine(iOutput);
            //Calculate permutation -> my code
            for (int i = 1; i < (iMax); i++)
            {
                Console.WriteLine("Multipling iMaxPermutation: " + iMaxPermutation + "By: " + (iMax - i));

                iMaxPermutation = iMaxPermutation * (iMax - i);
            }

            for (int i = 1; i < (iSize); i++)
            {
                Console.WriteLine("Multipling iPermutationDivisor: " + iPermutationDivisor + "By: " + (iSize - i));
                iPermutationDivisor = iPermutationDivisor * (iSize - i);
                //Console.WriteLine("Multipling iPermutationDivisor: " + iPermutationDivisor + "By: " + (iSize - i));
                Console.WriteLine("iPermutationDivisor: " + iPermutationDivisor);
            }
            iOutput = (iMaxPermutation / iPermutationDivisor);

            Console.WriteLine(iOutput);

            
            //Another option is to iterate through the grid manually:
            int[,] iGrid = new int[iSize + 1, iSize + 1];
            for (int i = 0; i < (iSize + 1); i++)
            {
                iGrid[i,0] = 1;
                iGrid[0,i] = 1;
            }
            for (int i  = 1; i < (iSize + 1); i++)
            {
                for (int i2 = 1; i2 < (iSize + 1); i2++)
                {
                    iGrid[i, i2] = iGrid[(i - 1), i2] + iGrid[i, (i2 - 1)];
                }
               
            }
            //Console.WriteLine(iGrid[iSize, iSize]);

            Console.Read();
        }
    }
}
