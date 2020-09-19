using System;
using System.Security.Cryptography.X509Certificates;

namespace Adapter_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySystem = new Sistema("Система с Цельсиями");
            var sensor = new FahrenhateSensor("Sensor1");
            var adapterSensor = new FahrenhateSensorAdapter(sensor);

            Console.WriteLine($"Температура работы системы \"{mySystem.Name}\" c адаптером датчика: {mySystem.GetTemperature(adapterSensor)} C");
        }
    }
}
