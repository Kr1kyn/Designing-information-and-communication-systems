using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class AutopilotSystem : DecoratorOptions
    {
        public AutopilotSystem(AutoBase auto,string title) : base(auto, title)
        {
            AutoProperty = auto;
            Name = auto.Name + ". Самоупраялемый";
            Description = auto.Description + ". " + this.Title + ". Современаая система датчиков с необходимым ПО для того чтобы вести машину без рук";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 350;
        }
    }
}
