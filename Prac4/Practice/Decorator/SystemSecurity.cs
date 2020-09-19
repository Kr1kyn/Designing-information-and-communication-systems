using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class SystemSecurity : DecoratorOptions
    {
        public SystemSecurity(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Повышенной безопасности";
            Description = p.Description + ". " + this.Title + ". Передние боковые подушки безопасности, ESP - система динамической стабилизации автомобиля";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 20.99;
        }
    }
}
