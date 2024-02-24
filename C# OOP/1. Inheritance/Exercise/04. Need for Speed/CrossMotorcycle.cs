﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpped
{
    public class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double DefaultFuelConsumption { get; set; }
        public override double FuelConsumption => 1.25;

        public override void Drive(double km)
        {
            Fuel -= km * FuelConsumption;
        }
        public override string ToString()
        {
            return $"Left fuel {Drive:f2}";
        }
    }
}
