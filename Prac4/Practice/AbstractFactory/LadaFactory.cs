using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class LadaFactory : CarFactory
    {
        private static Lazy<LadaFactory> factory = new Lazy<LadaFactory>(() => new LadaFactory());
        public static LadaFactory Factory
        {
            get
            {
                return factory.Value;
            }
        }
        private LadaFactory() { }
        public override AbstarctBody CreateBody()
        {
            return new LadaBody();
        }

        public override AbstractCar CreateCar()
        {
            return new LadaCar("Лада");
        }

        public override AbstractEngine CreateEngine()
        {
            return new LadaEngine();
        }
    }
}
