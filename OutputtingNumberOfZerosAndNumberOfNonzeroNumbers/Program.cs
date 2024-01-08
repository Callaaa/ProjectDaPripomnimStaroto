using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputtingCountOfZerosAndSumOfNonzeroNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 7
            Console.WriteLine("Enter 20 numbers");
            int[] arrayOfWholeNumbers = Console.ReadLine().Split(' ').Take(20).Select(int.Parse).ToArray();
            if (arrayOfWholeNumbers.Length < 20)
            {
                Console.WriteLine("NOT 20 NUMBERS");
            }
            else
            {
                int counterOfZeros = 0;
                int sumOfNonzeroNumbers = 0;
                bool isThereZeros = false;
                bool isThereNonzeroNumbers = false;
                for (int i = 0; i < arrayOfWholeNumbers.Length; i++)
                {
                    if (arrayOfWholeNumbers[i] == 0)
                    {
                        counterOfZeros++;
                        isThereZeros = true;
                    }
                    else
                    {
                        sumOfNonzeroNumbers += arrayOfWholeNumbers[i];
                        isThereNonzeroNumbers = true;
                    }
                }
                if (isThereZeros == true)
                {
                    Console.WriteLine("Count of zeros: " + counterOfZeros);
                }
                if (isThereNonzeroNumbers == true)
                {
                    Console.WriteLine("Sum of non zero numbers: " + sumOfNonzeroNumbers);
                }

            }

        }

    }
}

