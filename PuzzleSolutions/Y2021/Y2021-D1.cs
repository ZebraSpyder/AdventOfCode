using ChallengeSolutions.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleSolutions.Y2021
{
    public static class Y2021_D1
    {
        public static string SolvePart1()
        {
            List<int> puzzleInput = MyIO.ReadIntsFromFile(2021, 1, 1);
            int bigger = 0;
            for (int i = 1; i < puzzleInput.Count; i++)
            {
                if (puzzleInput[i] > puzzleInput[i - 1])
                {
                    bigger += 1;
                }
            }


            return $"{bigger}";
        }

        public static string SolvePart2()
        {
            List<int> puzzleInput = MyIO.ReadIntsFromFile(2021, 1, 1);

            int bigger = 0;
            for (int i = 0; i + 3 < puzzleInput.Count; i++)
            {
                int sum1 = puzzleInput[i] + puzzleInput[i+1] + puzzleInput[i+2];
                int sum2 = puzzleInput[i+1] + puzzleInput[i+2] + puzzleInput[i+3];
                
                if ( sum1 < sum2)
                {
                    bigger += 1;
                }
            }


            return $"{bigger}";
        }
    }
}
