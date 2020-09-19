using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class DrunkDriver : TransportService
    {
        private int tarif;
        public DrunkDriver(string name, int tarif) : base(name)
        {
            this.tarif = tarif;
        }
        public override double CostTransportation(double distance)
        {
            return tarif * distance;
        }
        public override string ToString()
        {
            return string.Format("Фирма {0}, доставка пьяного тела по тарифу {1}", Name, tarif);
        }
    }
}
