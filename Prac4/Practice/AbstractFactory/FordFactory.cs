using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class FordFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
        public override AbstarctBody CreateBody()
        {
            return new FordBody();
        }
    }
}
