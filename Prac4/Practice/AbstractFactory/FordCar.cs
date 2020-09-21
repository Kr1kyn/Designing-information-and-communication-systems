using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class FordCar : AbstractCar
    {
        public FordCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }
        public override string ToString()
        {
            return "Автомобиль " + Name;
        }
    }
}
