using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class AudiFactory : CarFactory 
    {

        public override AbstractCar CreateCar()
        {
            return new AudiCar("Audi");
        }

        public override AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }
        public override AbstarctBody CreateBody()
        {
            return new AudiBody();
        }
    }
}
