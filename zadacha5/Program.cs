using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5CheckIfNumberIsPrimeOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Въведи числа през интервал");
            IsNumberOddOrPrime number = new IsNumberOddOrPrime();

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            Console.WriteLine("Prime numbers:");
            Console.WriteLine(string.Join(" ",number.PrimeNumbers(numbers)));

            Console.WriteLine("Even numbers: ");
            Console.WriteLine(string.Join(" ", number.EvenNumbers(numbers)));

        }
    }
}
