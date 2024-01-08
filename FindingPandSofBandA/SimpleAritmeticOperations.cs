using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingPandSofBandA
{
    public class SimpleAritmeticOperations
    {
        public int Summing(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public int Multiply(List<int> numbers)
        {
            int resultOfMultiplying = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                resultOfMultiplying *= numbers[i];
            }
            return resultOfMultiplying;
        }
        public bool IsPrime(int number)
        {
            bool result = true;

            for (int delitelq = 2; delitelq < number; delitelq++)
            {
                if (number % delitelq == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public List<int> PrimeNumbers(List<int> numbers)
        {
            List<int> primeNumbers = new List<int>();
            foreach (int item in numbers)
            {
                if (IsPrime(item))
                {
                    primeNumbers.Add(item);
                }
            }
            return primeNumbers;
        }
    }
}
