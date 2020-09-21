using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class AudiCar : AbstractCar
    {
        public AudiCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            return engine.max_speed;
        }
    }
}
