using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOf20NumbersFindingEmptySpaces
{
    public class MethodsForNumbers
    {

        public int FindSmallestNumber(int[] numbers)
        {
            int[] numbersOverZero = numbers.Where(x => x > 0).OrderBy(x => x).ToArray();
            if (numbersOverZero.Length > 0)
            {
                int smallestNumber = numbersOverZero.First();
                return smallestNumber;

            }
            else
            {
                return 0;
            }
        }
        public int FindBiggestNumber(int[] numbers)
        {
            int[] numbersOverZero = numbers.Where(x => x > 0).OrderBy(x => x).ToArray();
            if (numbersOverZero.Length > 0)
            {
                int biggestNumber = numbersOverZero.Last();
                return biggestNumber;
            }
            else
            {
                return 0;
            }

        }
    }
}
