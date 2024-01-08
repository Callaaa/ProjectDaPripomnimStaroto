using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCountOfAllNumbersAndCountOfNegavtiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 8
            Console.WriteLine("Enter numbers over an interval");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> listOfNumbersBeforeZero = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != 0)
                {
                    listOfNumbersBeforeZero.Add(numbers[i]);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Length of List before encountering zero: " + listOfNumbersBeforeZero.Count);

            Console.WriteLine("Count of negative numbers: " + listOfNumbersBeforeZero.Count(x => x < 0));
        }
    }
}
