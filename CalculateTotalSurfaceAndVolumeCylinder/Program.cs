using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTotalSurfaceAndVolumeCylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 2
            try
            {
                Console.Write("Enter radius of the Cylinder: ");
                double radius = double.Parse(Console.ReadLine());
                Console.Write("Enter height of the Cylinder: ");
                double height = double.Parse(Console.ReadLine());

                double totalSurface = 2 * 3.14 * radius * (radius + height);
                double volume = 3.14 * radius * radius * height;

                Console.WriteLine($"Total Surface: {totalSurface:F2}");
                Console.WriteLine($"Volume: {volume:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
        }
    }
}
