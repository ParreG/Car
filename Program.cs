namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Vad har du för bil? ex Toyota!");
            string carModel = Console.ReadLine();

            Console.WriteLine("Vad har du för bil? ex Corolla!");
            string carMake = Console.ReadLine();

            Console.WriteLine("Vilket år är din bil gjord?");
            int carYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hur många mil har din bil kört? ");
            double carMileage = Convert.ToDouble(Console.ReadLine());

            Car tesla = new Car(carMake, carModel, carYear);
            tesla.Mileage = carMileage;
            tesla.displayInfo();
            Console.WriteLine();

            bool usingCar = true;

            while (usingCar)
            {
                Console.WriteLine("Hur mycket körde du med bilen nästa dag?");
                double carMileageNextDay = Convert.ToDouble(Console.ReadLine());
                tesla.Mileage = carMileageNextDay;
                tesla.displayInfo();
                Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine($"Bilden: {_model} \nMärke: {_make}\nTillverkat år: {_year}\nHar nu gått: {_mileage}mil.");
            if ((_mileage / 1500) >= 1)
            {
                Console.WriteLine("Din bil behöver service var 1500 mil!");
                Console.WriteLine($"Du behöver ha gjort Service nr {(int) _mileage / 1500}, på din bil!");
            }
            
        }

    }


}
