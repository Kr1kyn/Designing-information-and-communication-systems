using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    class WalkingRoute : StrategyRoute
    {
        public WalkingRoute(string title) : base(title) { }
        public override void GetWay()
        {
            Console.WriteLine("Walking Route");
        }
    }
}
