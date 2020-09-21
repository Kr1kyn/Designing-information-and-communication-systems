using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ShipTransCom : TransportCompany
    {
        public ShipTransCom(string name) : base(name) { }
        public override TransportService Create(string n, int t) 
        {
            return new Shipping(Name, t); 
        }
    }
}
