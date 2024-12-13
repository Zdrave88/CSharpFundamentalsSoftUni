using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            string[] vehicleInfo = command.Split(" ");
            string typeOfVehicle = vehicleInfo[0];
            string model = vehicleInfo[1];
            string color = vehicleInfo[2];
            int horsepower = int.Parse(vehicleInfo[3]);

            vehicles.Add(new Vehicle(typeOfVehicle, model, color, horsepower));
        }

        while ((command = Console.ReadLine()) != "Close the Catalogue")
        {
            string vehicleModel = command;
            Vehicle found = null; 

            
            foreach (var vehicle in vehicles)
            {

                if (vehicle.Model == vehicleModel)
                {
                    found = vehicle; 
                    break; 
                }
            }
            if (found != null)
            {
                Console.WriteLine($"Type: {found.Type}");
                Console.WriteLine($"Model: {found.Model}");
                Console.WriteLine($"Color: {found.Color}");
                Console.WriteLine($"Horsepower: {found.Horsepower}");
            }
        }

        double totalCarsHorsepower = 0;
        double totalTrucksHorsepower = 0;
        int carCount = 0;
        int truckCount = 0;

        foreach (var vehicle in vehicles)
        {
            if (vehicle.Type == "car")
            {
                totalCarsHorsepower += vehicle.Horsepower;
                carCount++;
            }
            else if (vehicle.Type == "truck")
            {
                totalTrucksHorsepower += vehicle.Horsepower;
                truckCount++;
            }
        }

        if (carCount > 0)
        {
            double averageCarHorsepower = totalCarsHorsepower / carCount;
            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsepower:F2}.");
        }
        else
        {
            Console.WriteLine("Cars have average horsepower of: 0.00.");
        }

        if (truckCount > 0)
        {
            double averageTruckHorsepower = totalTrucksHorsepower / truckCount;
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsepower:F2}.");
        }
        else
        {
            Console.WriteLine("Trucks have average horsepower of: 0.00.");
        }
    }
}

class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }

    public Vehicle(string type, string model, string color, int horsepower)
    {
        Type = type; 
        Model = model;
        Color = color;
        Horsepower = horsepower;
    }
}
