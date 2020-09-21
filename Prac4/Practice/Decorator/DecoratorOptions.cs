using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class DecoratorOptions : AutoBase
    {
        public AutoBase AutoProperty { protected get; set; }
        public string Title { get; set; }
        public DecoratorOptions(AutoBase au, string tit)
        {
            AutoProperty = au;
            Title = tit;
        }
    }
}
