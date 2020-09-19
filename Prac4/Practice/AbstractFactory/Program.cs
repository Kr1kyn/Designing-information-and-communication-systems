using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = new FordFactory();
            Client c1 = new Client(ford_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час с кузовом типа \"{2}\"", c1.ToString(), c1.RunMaxSpeed(),c1.GetBodyStyle());

            CarFactory audiCar = new AudiFactory();
            Client clientForAudi = new Client(audiCar);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час с кузовом типа \"{2}\"", clientForAudi.Name, clientForAudi.RunMaxSpeed(), clientForAudi.GetBodyStyle());

            var Lada = LadaFactory.Factory;
            Client clientForLada = new Client(Lada);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час с кузовом типа \"{2}\"", clientForLada.Name, clientForLada.RunMaxSpeed(), clientForLada.GetBodyStyle());
        }
    }
}
