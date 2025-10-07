using CarzCo.Vehicles;
using CarzCo.Vehicles.Cars;
using CarzCo.Vehicles.Bus;
using CarzCo.Vehicles.Boats;
using CarzCo.Vehicles.Motorcycles;
using CarzCo.Vehicles.Trucks;
using CarzCo.Enums;

namespace CarzCo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle.BuyVehicle(vehicles, new Car("Volvo", "V60", 150, 5, FuelType.Petrol, 5));
            Vehicle.BuyVehicle(vehicles, new Car("Volkswagen", "Golf", 130, 5, FuelType.Diesel, 5));
            Vehicle.BuyVehicle(vehicles, new Car("Volkswagen", "T-Roc", 140, 5, FuelType.Hybrid, 5));
            Vehicle.BuyVehicle(vehicles, new Car("Volkswagen", "ID4", 170, 5, FuelType.Electric, 5));
            Vehicle.BuyVehicle(vehicles, new Car("Toyota", "COMS", 15, 2, FuelType.Petrol, 3));
            Vehicle.BuyVehicle(vehicles, new Motorcycle("Harley-Davidson", "Street 750", 200, 2, FuelType.Petrol, 2, "Brown", false));
            Vehicle.BuyVehicle(vehicles, new Truck("Scania", "R500", 100, 3, FuelType.Diesel, 5000));
            Vehicle.BuyVehicle(vehicles, new Bus("MAN", "Not Airbus", 100, 80, FuelType.Electric, 3, true, 4, BusType.Blue));
            Vehicle.BuyVehicle(vehicles, new Boat("Targa", "Type 42", 50, 10, FuelType.Diesel, "Molly", BoatType.Motorboat, MotorboatEngineType.Inboard));
            Vehicle.BuyVehicle(vehicles, new Boat("Örnvik", "Type 500", 70, 4, FuelType.Petrol, "Molly", BoatType.Motorboat, MotorboatEngineType.Outboard));

            var vehicleToSell = vehicles.Find(v => v.Brand == "Volvo");
            if (vehicleToSell != null)
            {
                Vehicle.SellVehicle(vehicles, vehicleToSell);
            }
            else
            {
                Console.WriteLine("No vehicle matching sell criteria");
            }

            Console.WriteLine("\nListing vehicles with the brand \"Volkswagen\" that run at least 135 km/h:");

            List<Vehicle> filteredVehicles = Vehicle.FilterVehicles(vehicles, v => v.Brand == "Volkswagen" && v.MaxSpeed >= 135);
            Vehicle.PrintList(filteredVehicles);

            Console.WriteLine("\nRemaining cars sorted by max speed:");
            var sortedVehicles = vehicles.OrderByDescending(v => v.MaxSpeed).ToList();
            Vehicle.PrintList(sortedVehicles);

            Console.WriteLine("\nDiesel cars:");
            var dieselVehicles = vehicles.FindAll(vehicle => vehicle.Fuel == FuelType.Diesel).ToList();
            Vehicle.PrintList(dieselVehicles);
        }
    }
}
