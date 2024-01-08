using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticProgression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 6
            Console.Write("Enter ПЪРВИ ЧЛЕН /a1/: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Enter РАЗЛИКА /d/: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter ПОСЛЕДЕН ЧЛЕН /aN/: ");
            int aN = int.Parse(Console.ReadLine());
            CalculateTasksInAritmeticProgression calculatorOfOperations = new CalculateTasksInAritmeticProgression();
            Console.WriteLine("Sn: " + calculatorOfOperations.FindingSnOfThisProgression(a1, d, aN));
            Console.WriteLine("Elements: " + string.Join(" ", calculatorOfOperations.FindingAllElementOfAritmeticProgression(a1, d, aN)));

            List<int> elementsOfProgression = calculatorOfOperations.FindingAllElementOfAritmeticProgression(a1, d, aN);
            int lengthOfProgression = elementsOfProgression.Count;

            int indexOfMiddleNumber = lengthOfProgression / 2;
            int middleNumber = elementsOfProgression[indexOfMiddleNumber];

            int indexOfSecondMiddleNumber = lengthOfProgression / 2 - 1;
            int secondMiddleNumber = elementsOfProgression[indexOfSecondMiddleNumber];

            Console.WriteLine("Middle numbers: " + middleNumber + " And " + secondMiddleNumber);
            if (aN % 2 == 0)
            {
                int averageNumber = (secondMiddleNumber + middleNumber) / 2;
                Console.WriteLine("Average number when aN is prime: " + averageNumber);
            }



        }

    }
}
