using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOf20NumbersFindingEmptySpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 11
            int[] numbers = new int[20];
            MethodsForNumbers methodsForTheNumbers = new MethodsForNumbers();
            Console.WriteLine("This is a list of 20 numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number:" + i + "  -  ");
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] == 0)
                {
                    break;
                }
                else
                {
                    numbers[i] = numbers[i];
                }
            }

            int countOfEmptySpaces = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    countOfEmptySpaces++;

                }
            }

            Console.WriteLine("Count of empty spaces: " + countOfEmptySpaces);
            Console.WriteLine("Smallest number: " + methodsForTheNumbers.FindSmallestNumber(numbers));
            Console.WriteLine("Biggest number: " + methodsForTheNumbers.FindBiggestNumber(numbers));
        }

    }
}
