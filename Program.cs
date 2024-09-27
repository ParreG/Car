using System;

namespace Car_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många bilars information vill du skriva in?");
            int howManyCars = Convert.ToInt32(Console.ReadLine());

            Car[] registeredCars = new Car[howManyCars];
            Car automobile;

            for (int i = 0; i < howManyCars; i++)
            {
                Console.WriteLine($"Vad är bil bil nr {i + 1}? ex Toyota!");
                string carModel = Console.ReadLine();

                Console.WriteLine("Vad har bilen för modell? ex Corolla!");
                string carMake = Console.ReadLine();

                Console.WriteLine("Vilket år är bilen gjord?");
                int carYear = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hur många mil har bilen kört? ");
                double carMileage = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                if (i < howManyCars - 1)
                {
                    Console.WriteLine("Nu till nästa bil!");
                    Console.WriteLine();
                }
                automobile = new Car(carMake, carModel, carYear);
                automobile.Mileage = carMileage;
                registeredCars[i] = automobile;
            }

            for (int i = 0; i < registeredCars.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Din bil nr {i + 1}: ");
                registeredCars[i].displayInfo();
            }
            bool usingCar = true;

            while (usingCar)
            {

                Console.WriteLine("\nVilken bils mileage skulle du vilja ändra?\nOm du vill avsluta programmet skriv 0!");
                Console.WriteLine("Svara med siffror, ex 1: ");
                int chooseCar = Convert.ToInt32(Console.ReadLine());

                if (chooseCar == 0)
                {
                    Console.WriteLine("Programmet avslutas!");
                    break;
                }

                for (int i = chooseCar - 1; i < chooseCar; i++)
                {
                    Console.WriteLine($"Bil nummer: {i + 1}: \n");
                    Console.WriteLine("Hur mycket mer har bilen kört?\nAnge i mil:");
                    double carMileageNextDay = Convert.ToDouble(Console.ReadLine());
                    registeredCars[i].Mileage = carMileageNextDay;
                    Console.WriteLine("Här kommer en uppdaterad information om bilen: ");
                    registeredCars[i].displayInfo();
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

    public class Car
    {
        string _make;
        string _model;
        int _year;
        double _mileage = 0;
        public double Mileage
        {
            get { return _mileage; }
            set
            {
                _mileage += value;
            }
        }

        public Car(string make, string model, int year)
        {
            this._make = make;
            this._model = model;
            this._year = year;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Bilden: {_model} \nMärke: {_make}\nTillverkat år: {_year}\nHar nu gått: {_mileage}mil.");
            if ((_mileage / 1500) >= 1)
            {
                Console.WriteLine("Din bil behöver service var 1500 mil!");
                Console.WriteLine($"Du behöver ha gjort Service nr {(int)_mileage / 1500}, på din bil!");
            }

        }

    }



