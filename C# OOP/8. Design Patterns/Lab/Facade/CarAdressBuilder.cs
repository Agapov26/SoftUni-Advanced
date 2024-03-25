using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CarAdressBuilder : CarBuilderFacade
    {
        public CarAdressBuilder(Car car)
        {
            Car = car;
        }

        public Car Car { get; }

        public CarAdressBuilder InCity(string city)
        {
            Car.City = city;
            return this;
        }

        public CarAdressBuilder AtAdress(string address)
        {
            Car.Address = address;
            return this;
        }
    }
}
