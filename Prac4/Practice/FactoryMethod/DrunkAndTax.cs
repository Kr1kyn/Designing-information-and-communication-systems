using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class DrunkAndTax : TransportCompany
    {
        public DrunkAndTax(string name) : base(name) { }
        public override TransportService Create(string n, int k)
        {
            return new DrunkDriver(Name, k);
        }
    }
}
