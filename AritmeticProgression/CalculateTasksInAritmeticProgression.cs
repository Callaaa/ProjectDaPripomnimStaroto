using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticProgression
{
    public class CalculateTasksInAritmeticProgression
    {
        public List<int> FindingAllElementOfAritmeticProgression(int a1, int d, int aN)
        {
            List<int> listOfTheNumbers = new List<int>();
            for (int i = 0; i < aN; i++)
            {
                int number = a1 + (i * d);
                listOfTheNumbers.Add(number);
            }
            return listOfTheNumbers;
        }
        public int FindingSnOfThisProgression(int a1, int d, int aN)
        {
            int sum = 0;
            for (int i = 0; i < aN; i++)
            {
                sum = aN * (2 * a1 + (aN - 1) * d) / 2;

            }
            return sum;
        }

    }
}
