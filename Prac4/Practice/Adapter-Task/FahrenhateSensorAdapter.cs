using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Task
{
    class FahrenhateSensorAdapter : ISensor
    {
        private FahrenhateSensor sensor;
        public FahrenhateSensorAdapter(FahrenhateSensor sensor)
        {
            this.sensor = sensor;
        }
        public double GetTemperature()
        {
            return 5 * (sensor.GetTemperatureInFahrenheit() - 32) / 9;
        }
    }
}
