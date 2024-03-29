﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) :
        base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public override void Drive(double distance)
        {
            double currentFuelConsumption = this.FuelConsumption + 1.4;
            double neededFuel = distance * currentFuelConsumption;

            if (FuelQuantity >= neededFuel)
            {
                Console.WriteLine($"Bus travelled {distance} km");
                this.FuelQuantity -= neededFuel;
            }

            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }
    }
}
