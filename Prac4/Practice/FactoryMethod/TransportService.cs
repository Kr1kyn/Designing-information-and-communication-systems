using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class TransportService
    {
        public string Name { get; set; }
        public TransportService(string name)
        { 
            Name = name;
        }
        abstract public double CostTransportation(double distance);
    }
}
