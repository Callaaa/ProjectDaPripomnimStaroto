using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputtingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 3
            Console.Write("Въведи число: ");
            int number = int.Parse(Console.ReadLine());
            string theNumberToString = number.ToString();

            for (int i = 0; i < 1; i++)
            {
                if (number > 0)
                {
                    if (theNumberToString.Length == 1)
                    {
                        Console.WriteLine("Цифрата на единиците е: " + theNumberToString[i]);
                    }
                    else
                    if (theNumberToString.Length == 2)
                    {
                        Console.WriteLine("Цифрата на десетиците е: " + theNumberToString[i]);
                        Console.WriteLine("Цифрата на единиците е: " + theNumberToString[i + 1]);
                    }
                    else
                    if (theNumberToString.Length == 3)
                    {
                        Console.WriteLine("Цифрата на стотиците e: " + theNumberToString[i]);
                        Console.WriteLine("Цифрата на десетиците е: " + theNumberToString[i + 1]);
                        Console.WriteLine("Цифрата на единиците е: " + theNumberToString[i + 2]);
                    }
                    else
                    if (theNumberToString.Length == 4)
                    {
                        Console.WriteLine("Цифрата на хилядите e: " + theNumberToString[i]);
                        Console.WriteLine("Цифрата на стотиците e: " + theNumberToString[i + 1]);
                        Console.WriteLine("Цифрата на десетиците е: " + theNumberToString[i + 2]);
                        Console.WriteLine("Цифрата на единиците е: " + theNumberToString[i + 3]);
                    }
                    else
                    if (theNumberToString.Length == 5)
                    {
                        Console.WriteLine("Цифрата на десетки хилядите e: " + theNumberToString[i]);
                        Console.WriteLine("Цифрата на хилядите e: " + theNumberToString[i + 1]);
                        Console.WriteLine("Цифрата на стотиците e: " + theNumberToString[i + 2]);
                        Console.WriteLine("Цифрата на десетиците е: " + theNumberToString[i + 3]);
                        Console.WriteLine("Цифрата на единиците е: " + theNumberToString[i + 4]);
                    }
                    else
                    if (theNumberToString.Length == 6)
                    {
                        Console.WriteLine("Цифрата на стотици хиляди e: " + theNumberToString[i]);
                        Console.WriteLine("Цифрата на десетки хиляди e: " + theNumberToString[i + 1]);
                        Console.WriteLine("Цифрата на хилядите e: " + theNumberToString[i + 2]);
                        Console.WriteLine("Цифрата на стотиците e: " + theNumberToString[i + 3]);
                        Console.WriteLine("Цифрата на десетиците е: " + theNumberToString[i + 4]);
                        Console.WriteLine("Цифрата на единиците е: " + theNumberToString[i + 5]);
                    }
                    else
                    if (theNumberToString.Length == 7)
                    {
                        Console.WriteLine("Цифрата на милионите e: " + theNumberToString[i]);
                        Console.WriteLine("Цифрата на стотици хиляди e: " + theNumberToString[i + 1]);
                        Console.WriteLine("Цифрата на десетки хиляди e: " + theNumberToString[i + 2]);
                        Console.WriteLine("Цифрата на хилядите e: " + theNumberToString[i + 3]);
                        Console.WriteLine("Цифрата на стотиците e: " + theNumberToString[i + 4]);
                        Console.WriteLine("Цифрата на десетиците е: " + theNumberToString[i + 5]);
                        Console.WriteLine("Цифрата на единиците е: " + theNumberToString[i + 6]);
                    }
                    else
                    if (theNumberToString.Length == 8)
                    {
                        Console.WriteLine("Цифрата на десетки милиони e: " + theNumberToString[i]);
                        Console.WriteLine("Цифрата на милионите e: " + theNumberToString[i + 1]);
                        Console.WriteLine("Цифрата на стотици хиляди e: " + theNumberToString[i + 2]);
                        Console.WriteLine("Цифрата на десетки хиляди e: " + theNumberToString[i + 3]);
                        Console.WriteLine("Цифрата на хилядите e: " + theNumberToString[i + 4]);
                        Console.WriteLine("Цифрата на стотиците e: " + theNumberToString[i + 5]);
                        Console.WriteLine("Цифрата на десетиците е: " + theNumberToString[i + 6]);
                        Console.WriteLine("Цифрата на единиците е: " + theNumberToString[i + 7]);
                    }
                    else
                    if (theNumberToString.Length == 9)
                    {
                        Console.WriteLine("Цифрата на стотици милиони e: " + theNumberToString[i]);
                        Console.WriteLine("Цифрата на десетки милиони e: " + theNumberToString[i + 1]);
                        Console.WriteLine("Цифрата на милионите e: " + theNumberToString[i + 2]);
                        Console.WriteLine("Цифрата на стотици хилядите e: " + theNumberToString[i + 3]);
                        Console.WriteLine("Цифрата на десетки хиляди e: " + theNumberToString[i + 4]);
                        Console.WriteLine("Цифрата на хилядите e: " + theNumberToString[i + 5]);
                        Console.WriteLine("Цифрата на стотиците e: " + theNumberToString[i + 6]);
                        Console.WriteLine("Цифрата на десетиците е: " + theNumberToString[i + 7]);
                        Console.WriteLine("Цифрата на единиците е: " + theNumberToString[i + 8]);
                    }
                }
                else
                {
                    Console.WriteLine("Не работи с нулеви или отрицателни числа!");
                }

            }
        }
    }
}
