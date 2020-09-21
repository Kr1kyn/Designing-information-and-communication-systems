using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class AudioSystem : DecoratorOptions
    {
        public AudioSystem(AutoBase auto, string title) : base(auto, title)
        {
            AutoProperty = auto;
            Name = auto.Name + ". Громкий";
            Description = auto.Description + ". " + this.Title + ". Дополнительно встроенные японские колонки в корпус автомобиля";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 100;
        }
    }
}
