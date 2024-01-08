using CarInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 10

            try
            {
                Console.Write("Enter number of players: ");
                int numberOfPlayers = int.Parse(Console.ReadLine());
                Car cars;

                List<int> listOfYears = new List<int>();
                List<Car> listOfCars = new List<Car>();
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    Console.WriteLine("Enter: 1-Brand; 2-Model, 3-Registration Number, 4-Year of manifacture.");
                    var carInformation = Console.ReadLine().Split(' ');
                    cars = new Car(carInformation[0], carInformation[1], carInformation[2], int.Parse(carInformation[3]));
                    int year = int.Parse(carInformation[3]);
                    listOfCars.Add(cars);
                    Console.WriteLine(cars.CheckIfCarEco(year));
                }
                Console.WriteLine("Number of players: " + numberOfPlayers);
                foreach (Car aCar in listOfCars)
                {
                    Console.WriteLine();
                    Console.WriteLine(aCar.Print());
                    Console.WriteLine(aCar.Print2());
                }
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Format");
            }

        }
    }
}
