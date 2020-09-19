using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportCompany trCom = new TaxiTransCom("Служба такси");
            TransportService compService = trCom.Create("Такси", 1);
            double dist = 15.5;
            Print(compService, dist);

            TransportCompany gCom = new ShipTransCom("Служба перевозок");
            compService = gCom.Create("Грузоперевозки", 2);
            double distg = 150.5;
            Print(compService, distg);

            TransportCompany DrunkedTaxi = new DrunkAndTax("Drunk&Tax");
            compService = DrunkedTaxi.Create("Пьяное такси", 4);
            Print(compService, 200);
        }

       
        private static void Print(TransportService compTax, double distg)
        { 
            Console.WriteLine("Компания {0}, расстояние {1}, стоимость: {2}", compTax.ToString(), distg, compTax.CostTransportation(distg));
        }
    }
}
