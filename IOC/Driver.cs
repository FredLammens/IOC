using IOC.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace IOC
{
    public class Driver
    {
        private ICar _car = null;
        private ICarKey _key = null;
        private string _name;

        [InjectionConstructor]
        public Driver(ICar car)
        {
            _car = car;
        }

        public Driver(ICar car, ICarKey key) : this(car)
        {
            _key = key;
        }
        public Driver(ICar car,string driverName) 
        {
            _car = car;
            _name = driverName;

        }

        public void RunCar() 
        {
            //Console.WriteLine("Running {0} - {1} mile", _car.GetType().Name, _car.Run());
            //Console.WriteLine("Running {0} with {2} - {1} mile",_car.GetType().Name, _car.Run(),_key.GetType().Name);
            Console.WriteLine($"{_name} is running {_car.GetType().Name} - {_car.Run()} mile");
        }
    }
}
