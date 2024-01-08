using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarInformation
{
    public class Car
    {
        private string brand;
        private string model;
        private string registrationNumber;
        private int yearOfmanifacture;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be null or empty");
                }
                brand = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be null or empty");
                }
                model = value;
            }
        }
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be null or empty");
                }
                registrationNumber = value;
            }
        }
        public int YearOfmanifacture
        {
            get { return yearOfmanifacture; }
            set
            {
                if (yearOfmanifacture.ToString().Length > 4)
                {
                    throw new ArgumentException("Wrong year");
                }
                yearOfmanifacture = value;
            }
        }
        public Car()
        {

        }
        public Car(string brand, string model, string registrationNumber, int yearOfmanifacture)
        {
            this.Brand = brand;
            this.Model = model;
            this.RegistrationNumber = registrationNumber;
            this.YearOfmanifacture = yearOfmanifacture;
        }


        public string Print()
        {

            return $"Движа се {this.Brand} {this.Model}: Brym – brum -brum";
        }
        public string Print2()
        {
            return $"Представям се: Brand: {this.Brand}, Model: {this.Model}, NumberOfRegistration: {this.registrationNumber}, Year: {this.yearOfmanifacture}";

        }
        public string CheckIfCarEco(int yearOfmanifacture)
        {

            if (yearOfmanifacture > 2000)
            {
                return "Екологична ли съм - ECO";
            }
            return "Екологична ли съм - I’m NOT Eco CAR";
        }
    }
}
