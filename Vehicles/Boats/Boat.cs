using CarzCo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarzCo.Vehicles.Boats
{
    internal class Boat : Vehicle
    {
        public string Name { get; set; }
        public BoatType TypeOfBoat { get; set; }
        public MotorboatEngineType BoatEngineType { get; set; }

        public Boat(string brand, string model, int maxSpeed, int passengerCapacity, FuelType fuel, string name, BoatType boat, MotorboatEngineType boatEngineType) : base(brand, model, maxSpeed, passengerCapacity, fuel)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            PassengerCapacity = passengerCapacity;
            Fuel = fuel;
            Name = name;
            TypeOfBoat = boat;
            BoatEngineType = boatEngineType;
        }
    }
}
