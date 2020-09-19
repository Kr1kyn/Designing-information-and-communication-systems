using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class AbstractCar
    {
        public string Name { get; set;}
        public abstract int MaxSpeed(AbstractEngine engine);
    }
}
