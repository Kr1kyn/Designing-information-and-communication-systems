using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePaying
{
    class CashPayment : Paying
    {
        public CashPayment(string product, double sum) : base(product, sum) { }
        protected override void СhargeGoods(double sum)
        {
            Console.WriteLine($"Оплата наличными в пункте выдачи");
        }
    }
}
