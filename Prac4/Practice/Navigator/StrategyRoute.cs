using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    abstract class StrategyRoute
    {
        public string Title { get; }
        public StrategyRoute(string title)
        {
            Title = title;
        }
        public abstract void GetWay();
    }
}
