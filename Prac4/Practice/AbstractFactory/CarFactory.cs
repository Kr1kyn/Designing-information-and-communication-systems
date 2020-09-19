using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class CarFactory
    {
        public abstract AbstractCar CreateCar();
        public abstract AbstractEngine CreateEngine();
        public abstract AbstarctBody CreateBody();
    }
}
