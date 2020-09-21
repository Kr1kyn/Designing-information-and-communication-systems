using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Nisan : AutoBase
    {
        public Nisan(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }
        public override double GetCost()
        {
            return CostBase * 1.25;
        }
    }
}
