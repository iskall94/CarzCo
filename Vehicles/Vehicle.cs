using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarzCo.Enums;

namespace CarzCo.Vehicles
{
    internal abstract class Vehicle 
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int PassengerCapacity { get; set; }
        public FuelType Fuel { get; set; }

        public Vehicle(string brand, string model, int maxSpeed, int passengerCapacity, FuelType fuelType)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            PassengerCapacity = passengerCapacity;
            Fuel = fuelType;
        }

        public override string ToString()
        {
            return $"{Brand} {Model}";
        }

        public static void PrintList(List<Vehicle> vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Brand} {vehicle.Model}, runs on {vehicle.Fuel}, takes {vehicle.PassengerCapacity} passengers and has a top speed {vehicle.MaxSpeed}");
            }
        }

        public static void BuyVehicle<T>(List<T> listToAddTo, T thingToAdd)
        {
            Console.WriteLine($"{thingToAdd} was added to the list");
            listToAddTo.Add(thingToAdd);

        }

        public static void SellVehicle(List<Vehicle> vehicles, Vehicle vehicle)
        {
            Console.WriteLine($"\nSells vehicle: {vehicle}");
            vehicles.Remove(vehicle);
        }

        public static List<Vehicle> FilterVehicles(List<Vehicle> vehicles, Func<Vehicle, bool> criteria)
        {
            return vehicles.Where(criteria).ToList();
        }
    }
}
