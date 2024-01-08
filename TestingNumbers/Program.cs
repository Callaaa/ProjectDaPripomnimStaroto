using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfNumberIsPrimeOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 5
            Console.WriteLine("Въведи числа през интервал");
            try
            {
                List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                List<int> primeNumbers = new List<int>();
                List<int> evenNumbers = new List<int>();
                bool thereIsPrimeNumbers = false;
                bool thereIsEvenNumbers = false;
                bool onlyPrint1Once = false;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > 1)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            primeNumbers.Add(numbers[i]);
                            thereIsPrimeNumbers = true;
                        }
                        if (numbers[i] % 2 == 1 || numbers[i] == 2)
                        {
                            evenNumbers.Add(numbers[i]);
                            thereIsEvenNumbers = true;
                        }
                    }
                    else
                    if (onlyPrint1Once == false)
                    {
                        Console.WriteLine("1 не е четно или просто число");
                        onlyPrint1Once = true;
                    }
                }
                if (thereIsPrimeNumbers == true)
                {
                    Console.WriteLine("Четни числа: " + string.Join(" ", primeNumbers));
                }
                if (thereIsEvenNumbers == true)
                {
                    Console.WriteLine("Прости числа: " + string.Join(" ", evenNumbers));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Грешен формат");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
