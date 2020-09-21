using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    class RouteByRoad : StrategyRoute
    {
        public RouteByRoad(string tittle) : base(tittle) { }
        public override void GetWay()
        {
            Console.WriteLine("Route by Road");
        }
    }
}
