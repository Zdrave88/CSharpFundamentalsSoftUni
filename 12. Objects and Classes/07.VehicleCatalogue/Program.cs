namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                //"{type}/{brand}/{model}/{horse power / weight}"
                string[] input = command.Split("/");
                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int numeric = int.Parse(input[3]);

                if (type == "Car")
                {
                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = numeric
                    };
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = numeric
                    };
                    trucks.Add(truck);
                }
            }
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {

                Console.WriteLine("Trucks:");
                foreach (var truck in trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    //class CatalogVehigle
    //{
    //    public List<Car> Cars { get; set; }
    //    public List<Truck> Trucks { get; set; }
    //}

}
