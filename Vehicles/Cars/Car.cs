using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarzCo.Enums;
using CarzCo.Interfaces;

namespace CarzCo.Vehicles.Cars
{
    internal class Car : Vehicle, IDriveable 
    {
        public int Doors { get; set; }
        public ColorType TypeOfColor { get; set; } = ColorType.Standard;
        public bool WinterTires { get; set; } = false;

        public Car(string brand, string model, int maxSpeed, int passengerCapacity, FuelType fuel, int doors) : base(brand, model, maxSpeed, passengerCapacity, fuel)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            PassengerCapacity = passengerCapacity;
            Fuel = fuel;
            Doors = doors;
        }

        public virtual void Drive()
        {
            Console.WriteLine($"The {Model} speeds forward");
        }
    }
}
