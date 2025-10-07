using CarzCo.Enums;
using CarzCo.Vehicles.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarzCo.Interfaces;

namespace CarzCo.Vehicles.Bus
{
    internal class Bus : Car, IDriveable
    {
        public bool InTraffic { get; set; }
        public int OnLine { get; set; }
        public BusType TypeOfBus { get; set; }

        public Bus(string brand, string model, int maxSpeed, int passengerCapacity, FuelType fuel, int doors, bool inTraffic, int line, BusType typeOfBus) : base(brand, model, maxSpeed, passengerCapacity, fuel, doors)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            PassengerCapacity = passengerCapacity;
            Fuel = fuel;
            Doors = doors;
            InTraffic = inTraffic;
        }
        

        public override void Drive()
        {
            Console.WriteLine("The bus is going on time.");
        }
    }
}
