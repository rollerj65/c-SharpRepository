
//

//The following iterative sequence is defined for the set of positive integers:

//n → n/2 (n is even)
//n → 3n + 1 (n is odd)

//Using the rule above and starting with 13, we generate the following sequence:
//13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

//It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

//Which starting number, under one million, produces the longest chain?

//NOTE: Once the chain starts the terms are allowed to go above one million.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int iCollatzSequenceLimit = 1000000;
            int iN = 0;
            int iIterator = 0;

            int iValueSequence1 = 2;
            int iValueSequence2 = 0;
            int iValueLongestString = 0;
            int iValueWithLongestSequence = 0;
            int iLongestSequenceCounter = 0;
                
            for (iN = 1; iN < iCollatzSequenceLimit; iN++)
                //for each numeric value, divide by 2 if even,  and multiply by 3n + 1 if odd
            {
                iLongestSequenceCounter = 0;
                Console.WriteLine("Number: " + iN);
                if (iN % 2 == 0)
                {
                    Console.WriteLine("Number: " + iN + " is even");
                    iValueSequence1 = (iN / 2);
                    Console.WriteLine("Dividing by two. Output: " + iValueSequence1);
                }
                else
                {
                    
                    iValueSequence1 = (iN * 3) + 1;
                    Console.WriteLine("Multiplying by 3. Adding 1. Output: " + iValueSequence1);
                }

                // if value from above isn't equal to 1, run logic again and again until you reach 1. Log number of times it takes.
                while (iValueSequence1 != 1)
                {
                    iLongestSequenceCounter++;
                    if (iLongestSequenceCounter > iValueLongestString)
                    {
                        iValueLongestString = iLongestSequenceCounter;
                        iValueWithLongestSequence = iN;
                    }

                    if (iValueSequence1 % 2 == 0)
                    {

                        Console.WriteLine("Number: " + iValueSequence1 + " is even");
                        iValueSequence1 = (iValueSequence1 / 2);
                        Console.WriteLine("Dividing by two. Output: " + iValueSequence1);
                    }
                    else
                    {
                        Console.WriteLine("Number: " + iValueSequence1 + " is odd");
                        iValueSequence1 = (iValueSequence1 * 3) + 1;
                        Console.WriteLine("Multiplying by 3. Adding 1. Output: " + iValueSequence1);
                    }
                }
            }
            Console.WriteLine("Longest Collatz Sequence in: " + iCollatzSequenceLimit + ". Sequence length: " + iValueLongestString + ". Number: " + iValueWithLongestSequence);
            Console.Read();
        }
    }
}
