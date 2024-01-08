using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePerimeterAndVolumeTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 1
            try
            {
                Console.WriteLine("Calculating Perimeter of the sides on a Triangle.");
                Console.Write("Enter side a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter side b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter side c: ");
                double c = double.Parse(Console.ReadLine());
                if (a > 0 && b > 0 && c > 0)
                {
                    double perimeter = a + b + c;
                    Console.WriteLine($"Perimeter of this Triangle = {perimeter}");

                    double halfPerimeter = perimeter / 2;
                    double volume = halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c);
                    Console.WriteLine(volume);
                    double roundedVolume = Math.Round(volume);
                    Console.WriteLine("Volume of this Triangle = " + roundedVolume);

                }
                else
                {
                    Console.WriteLine("This is not a side of a triangle");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Нецифрови данни");
            }

        }
    }
}
