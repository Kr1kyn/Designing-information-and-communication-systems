using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    abstract class StrategySort 
    { 
        public string Title { get; set; } 
        public abstract void Sort(int[] array); 
    }
}
