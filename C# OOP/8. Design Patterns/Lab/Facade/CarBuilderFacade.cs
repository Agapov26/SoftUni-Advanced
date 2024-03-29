﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CarBuilderFacade
    {
        protected Car car { get; set; }
        public Car Car { get; }

        public CarBuilderFacade() 
        { 
            Car = new Car();
        }

        public Car Build() => Car;
        public CarInfoBuilder Info => new CarInfoBuilder(Car);
        public CarAdressBuilder Built => new CarAdressBuilder(Car);
    }
}
