using System;

namespace WASP_HW
{
    public class Car
    {
        public string Brand { get; set; }
        protected int _power;
        protected int _yearOfProduction;

        public int Power
        {
            get => _power;
            set
            {
                if (value >= 0) { _power = value; }
            }
        }
        public int Year
        {
            get => _yearOfProduction;
            set
            {
                if (value > 1900 && value <= 2022) { _yearOfProduction = value; }
            }
        }

        public Car()
        {
            Brand = "Undefined";
            _power = 0;
            _yearOfProduction = 1900;
        }
        public Car(string brand, int power, int year)
        {
            Brand = brand;
            _power = power;
            _yearOfProduction = year;
        }
        public override string ToString()
        {
            return "Марка: " + $"{Brand}\n" + "Мощность: " + $"{_power}\n" + "Год выпуска: " + $"{_yearOfProduction}\n\n";
        }
    }

    public class PassengerCar : Car
    {
        private int _numberofpas;
        private Dictionary<string, int> _repairBook;
        public int NumberofPas
        {
            get => _numberofpas;
            set { if (value >= 0) { _numberofpas = value; } }
        }
        public Dictionary<string, int> RepairBook
        {
            get => _repairBook;
            set { _repairBook = value; }
        }
        public PassengerCar(string brand, int power, int year, int passnumb, Dictionary<string, int> repbook)
            : base(brand, power, year)
        {
            _numberofpas = passnumb;
            _repairBook = repbook;
        }
        public PassengerCar()
        {
            Dictionary<string, int> repbook = new Dictionary<string, int>() { };
            _repairBook = repbook;
        }

        public void AddItem(string det, int year)
        {
            _repairBook[det] = year;
        }

        public void PrintYearDet(string name)
        {
            Console.WriteLine(_repairBook[name]);
        }

        public void PrintRepBook()
        {
            foreach (KeyValuePair<string, int> item in _repairBook)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public override string ToString()
        {
            return "Марка: " + $"{Brand}\n" + "Мощность: " + $"{_power}\n" + "Год выпуска: " + $"{_yearOfProduction}\n" + "Кол-во мест: " + $"{_numberofpas}\n\n";
        }
    }
    public class Truck : Car
    {
        private int _maxweight;
        public string Drivename { get; private set; }
        Dictionary<string, int> _buggage;

        public int Maxweight
        {
            get { return _maxweight; }
            set { _maxweight = value; }
        }

        public Dictionary<string, int> Buggage
        {
            get { return _buggage; }
            set { _buggage = value; }
        }

        public Truck(string brand, int power, int year, int maxweight, string drivname, Dictionary<string, int> bag)
            : base(brand, power, year)
        {
            _maxweight = maxweight;
            Drivename = drivname;
            _buggage = bag;
        }
        public Truck()
        {
            Dictionary<string, int> bag = new Dictionary<string, int>();
            Drivename = "Ivan";
            _maxweight = 0;
            _buggage = bag;
        }

        public void ChangeDriver(string name)
        {
            Drivename = name;
        }
        public void AddBug(string name, int weight)
        {
            _buggage[name] = weight;
        }
        public void RemoveBug(string name)
        {
            if (_buggage.ContainsKey(name))
            {
                _buggage.Remove(name);
            }
            else
            {
                Console.WriteLine("Нет такого груза!");
            }
        }

        public void PrintBuggage()
        {
            foreach (KeyValuePair<string, int> item in _buggage)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }

        public override string ToString()
        {
            return "Марка: " + $"{Brand}\n" + "Мощность: " + $"{_power}\n" + "Год выпуска: " +
                $"{_yearOfProduction}\nМаксимальная грузоподъёмность: " + $"{_maxweight}\n" + "Имя водителя: " + $"{Drivename}\n\n";
        }



    }
    public class Autopark
    {
        private string _name;
        private List<Car> _cars;
        public string Name
        {
            get => _name;
            set { _name = value; }
        }
        public List<Car> Cars
        {
            get => _cars;
        }
        public Autopark()
        {
            _name = "Undef";
            _cars = new List<Car>();
        }
        public Autopark(string name, List<Car> cars) : this()
        {
            _name = name;
            _cars = cars;
        }

        public void collect(Car car)
        {
            _cars.Add(car);
        }
        public override string ToString()
        {
            string autopark = $"{_name}\n";
            foreach (Car car in _cars)
            {
                autopark += car.ToString();
            }
            return autopark;
        }


    }
    class Program
    {
        public static void Main()
        {
            Dictionary<string, int> repbook = new Dictionary<string, int> { { "aaaaa", 15 }, { "BBB", 20 } };
            PassengerCar bus = new PassengerCar("ISUZU", 300, 2019, 15, repbook);
            Truck truck = new Truck("KAMAZ", 450, 2015, 1000, "Nikolas", new Dictionary<string, int>() { });
            Car car1 = new Car();
            Car car2 = new Car("KIA", 120, 2021);
            Car bus2 = new PassengerCar("ISUZU", 300, 2019, 15, repbook);
            Car bus3 = new Truck();
            Autopark aut = new Autopark("Autopark 1", new List<Car>());
            aut.collect(car2);
            aut.collect(bus2);
            aut.collect(bus3);
            aut.collect(car1);
            aut.collect(bus);
            aut.collect(truck);
            Console.WriteLine(aut.ToString());
        }

    }
}