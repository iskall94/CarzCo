using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarzCo.Interfaces;
using CarzCo.Enums;

namespace CarzCo.Vehicles.Trucks
{
    internal class Truck : Vehicle, IDriveable
    {
        public int MaxCargoWeight { get; set; }
        private float _height;
        public float Height
        {
            get { return _height; }
            set
            {
                if (value < 2.5f)
                {
                    _height = 2.5f;
                }
                else if (value > 4.0f)
                {
                    _height = 4.0f;
                }
                else
                {
                    value = _height;
                }
            }
        }

        private int _amountTrailers;
        public int AmountTrailers 
        { 
            get { return _amountTrailers; }
            
            set
            {
                if(value <= 2)
                {
                    _amountTrailers = value;
                }
            } 
        }

        public Truck(string brand, string model, int maxSpeed, int passengerCapacity, FuelType fuel, int maxCargoWeight = 5000) : base(brand, model, maxSpeed, passengerCapacity, fuel)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            PassengerCapacity = passengerCapacity;
            Fuel = fuel;
            MaxCargoWeight = maxCargoWeight;
        }

        public void Drive()
        {
            Console.WriteLine("The truck drives forward.");
        }
    }
}
