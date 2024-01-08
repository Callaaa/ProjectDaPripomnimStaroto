using FindingPandSofBandA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingSumAndMultiplyingOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 9
            try
            {
                Console.Write("Enter the value of a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter the value of b: ");
                int b = int.Parse(Console.ReadLine());
                List<int> numbers = new List<int>();
                for (int i = a - 1; i < b; i++)
                {
                    numbers.Add(i + 1);
                }
                SimpleAritmeticOperations operations = new SimpleAritmeticOperations();
                Console.WriteLine("Sum of numbers: " + operations.Summing(numbers));
                Console.WriteLine("Result of multiplyed numbers: " + operations.Multiply(numbers));
                Console.WriteLine("Prime numbers: " + string.Join(" ", operations.PrimeNumbers(numbers)));
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }

        }
    }
}
