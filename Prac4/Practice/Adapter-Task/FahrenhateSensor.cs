using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Adapter_Task
{
    class FahrenhateSensor
    {
        private Random randomValue;
        public string Name { get; }
        public FahrenhateSensor(string name)
        {
            Name = name;
            randomValue = new Random();
        }

        public double GetTemperatureInFahrenheit()
        {
            return randomValue.NextDouble() * 200;
        }
    }
}
