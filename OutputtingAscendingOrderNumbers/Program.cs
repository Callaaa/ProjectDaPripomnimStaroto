using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputtingAscendingOrderNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 4
            Console.WriteLine("Enter numbers:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            numbers.Where(x => x > 0).OrderBy(x => x).ToList().ForEach(x => Console.Write(x + "< "));
            Console.WriteLine();

        }
    }
}
