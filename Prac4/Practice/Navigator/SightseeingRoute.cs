using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    class SightseeingRoute : StrategyRoute
    {
        public SightseeingRoute(string title) : base(title) { }
        public override void GetWay()
        {
            Console.WriteLine("Sightseeing Route");
        }
    }
}
