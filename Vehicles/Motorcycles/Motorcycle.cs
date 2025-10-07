using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarzCo.Interfaces;
using CarzCo.Enums;

namespace CarzCo.Vehicles.Motorcycles
{
    internal class Motorcycle : Vehicle, IDriveable
    {
        public string ColorCoat { get; set;}
        public bool Sidecart { get; set; }
        public int AmountWheels { get; set; }

        public Motorcycle(string brand, string model, int maxSpeed, int passengerCapacity, FuelType fuel, int amountWheels, string color = "red", bool sidecart = false) : base(brand, model, maxSpeed, passengerCapacity, fuel)
        {
            Brand = brand;
            Model = model;
            ColorCoat = color;
            Sidecart = sidecart;
            AmountWheels = amountWheels;
        }

        public void Drive()
        {
            Console.WriteLine("The motorcycle cruises by");
        }
    }
}
