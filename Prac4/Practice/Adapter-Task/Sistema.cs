using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Task
{
    class Sistema
    {
        public string Name { get; }
        public Sistema(string name)
        {
            Name = name;
        }

        public double GetTemperature(ISensor sensor)
        {
            return sensor.GetTemperature();
        }
    }
}
