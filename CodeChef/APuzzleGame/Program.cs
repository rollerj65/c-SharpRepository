//https://www.codechef.com/problems/H1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APuzzleGame
{
    class puzzle
    {
        int[,] Tiles = new int[3,3];
        int StepsNeeded = 0;

        puzzle(int[,] input) //create new puzzle by inputting integer array
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Tiles[x, y] = input[x, y];
                }
            }
        }

        public int SolvePuzzle(int[,] input)
        {
            bool PuzzleActive = true;
            int AboveSum = 0;
            bool AboveSumInvalid = false;
            int LeftSum = 0;
            bool LeftSumInvalid = false;
            int RightSum = 0;
            bool RightSumInvalid = false;
            int BelowSum = 0;
            bool BelowSumInvalid = false;
            int[,] FinalResult = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            int value1 = 0;
            int value2 = 0;

            while (PuzzleActive)
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        //check adjacent values to see if they add to equal prime number
                        #region try-catch blocks
                        try
                        {
                            AboveSum = input[x, y] + input[x, y + 1];
                        }
                        catch
                        {
                            AboveSumInvalid = true;
                        }

                        try
                        {
                            LeftSum = input[x, y] + input[x - 1, y];
                        }
                        catch
                        {
                            LeftSumInvalid = true;
                        }

                        try
                        {
                            RightSum = input[x, y] + input[x + 1, y];
                        }
                        catch
                        {
                            RightSumInvalid = true;
                        }

                        try
                        {
                            BelowSum = input[x, y] + input[x, y - 1];
                        }
                        catch
                        {
                            BelowSumInvalid = true;
                        }
                        #endregion
                        if (AboveSumInvalid != true && IsItPrime(AboveSum))
                        {
                            value1 = input[x, y];
                            value2 = input[x, y + 1];

                            input[x, y] = value2;
                            input[x, y + 1] = value1;
                            StepsNeeded++;
                            PuzzleActive = true;
                            continue;
                        }//IF sum is not invalid (it doesn't reach outside array) and it is prime, then swap. ELSE continue.
                        if (LeftSumInvalid != true && IsItPrime(LeftSum))
                        {
                            value1 = input[x, y];
                            value2 = input[x - 1, y];

                            input[x, y] = value2;
                            input[x - 1, y] = value1;
                            StepsNeeded++;
                            PuzzleActive = true;
                            continue;
                        }
                        if (RightSumInvalid != true && IsItPrime(RightSum))
                        {
                            value1 = input[x, y];
                            value2 = input[x + 1, y];

                            input[x, y] = value2;
                            input[x + 1, y] = value1;
                            StepsNeeded++;
                            PuzzleActive = true;
                            continue;
                        }
                        if (BelowSumInvalid != true && IsItPrime(BelowSum))
                        {
                            value1 = input[x, y];
                            value2 = input[x, y - 1];

                            input[x, y] = value2;
                            input[x, y - 1] = value1;
                            StepsNeeded++;
                            PuzzleActive = true;
                            continue;
                        }
                    }
                }
                if (StepsNeeded == 0)
                {
                    PuzzleActive = false;
                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            if(input[x,y] != FinalResult[x, y])
                            {
                                return -1;
                            }
                        }

                    }
                }
            }
            return 1;//placeholder return
        }

        public bool IsItPrime(int input)
        {
            for (int x = 0; x < input; x++)
            {
                if(x % input == 0 && x != 1)
                {
                    return true;
                }
            }

            return false;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int PuzzlesToSolve = 1;
            int[,] Input = new int[,] { { 1, 3, 2 }, { 6, 5, 4 }, { 8, 7, 9 } };


        }
    }
}
