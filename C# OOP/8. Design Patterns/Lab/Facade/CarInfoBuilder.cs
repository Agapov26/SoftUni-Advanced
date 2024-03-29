﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CarInfoBuilder : CarBuilderFacade
    {
        public CarInfoBuilder(Car car)
        {
            Car = car;
        }

        public Car Car { get; }

        public CarInfoBuilder WithType(string type)
        {
            Car.Type = type;
            return this;
        }

        public CarInfoBuilder WithColor(string color)
        {
            Car.Color = color;
            return this;
        }
        public CarInfoBuilder WithNumberOfDoors(int number)
        {
            Car.NumberOfDoors = number;
            return this;
        }

    }
}
