using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    class RouteByPublicTransport : StrategyRoute
    {
        public RouteByPublicTransport(string title) : base(title) { }
        public override void GetWay()
        {
            Console.WriteLine("Route by public transport");
        }
    }
}
