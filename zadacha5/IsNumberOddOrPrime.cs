using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5CheckIfNumberIsPrimeOrEven
{
    public class IsNumberOddOrPrime
    {

        public bool IsPrime(int number)
        {
            bool result = true;
            for (int delitela = 2; delitela < number; delitela++)
            {
                if (number % delitela == 0)
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

        public bool IsEven(int number)
        {
            bool result = false;
            for (int i = 0; i < number; i++)
            {
                if (number % 2 == 0)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        public List<int> EvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int item in numbers)
            {
                if (IsEven(item))
                {
                    evenNumbers.Add(item);
                }
            }
            return evenNumbers;
        }
    }
}
