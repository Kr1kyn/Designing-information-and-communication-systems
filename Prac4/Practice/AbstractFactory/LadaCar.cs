using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class LadaCar : AbstractCar
    {
        public LadaCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            return engine.max_speed;
        }
        public override string ToString()
        {
            return "Автомобиль " + Name;
        }
    }
}
