using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class TaxiServices : TransportService
    {
        public int Category { get; set; }
        public TaxiServices(string name, int cat) : base(name)
        {
            Category = cat;
        }
        public override double CostTransportation(double distance) 
        { 
            return distance * Category;
        }
        public override string ToString() 
        {
            string s = string.Format("Фирма {0}, поездка категории {1}", Name, Category); 
            return s; 
        }
    }
}
