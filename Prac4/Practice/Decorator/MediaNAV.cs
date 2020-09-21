using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class MediaNAV : DecoratorOptions
    {
        public MediaNAV(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Современный";
            Description = p.Description + ". " + this.Title + ". Обновленная мультимедийная навигационная система";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 15.99;
        }
    }
}
