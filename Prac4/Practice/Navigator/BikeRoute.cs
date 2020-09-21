using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    class BikeRoute : StrategyRoute
    {
        public BikeRoute(string title) : base(title) { }
        public override void GetWay()
        {
            Console.WriteLine("Bike Route");
        }
    }
}
