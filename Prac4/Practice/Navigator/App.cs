using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    class App
    {
        public string Name { get; }
        private StrategyRoute route;
        public App(string name)
        {
            Name = name;
        }

        public void SetRoute(StrategyRoute route)
        {
            this.route = route;
        }

        public void ViewMap()
        {
            route.GetWay();
        }
    }
}
