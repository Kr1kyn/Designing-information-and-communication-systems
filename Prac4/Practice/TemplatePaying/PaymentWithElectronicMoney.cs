using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePaying
{
    class PaymentWithElectronicMoney : Paying
    {
        private double tax;
        public double Tax {
            get 
            { 
                return tax - 1; 
            }
            private set
            {
                tax = value;
            }
        }

        public PaymentWithElectronicMoney(string product, double sum, double tax) : base(product, sum)
        {
            Tax = tax;
        }
        protected override void СhargeGoods(double sum)
        {
            Console.WriteLine($"С вашей карты списалась сумма {sum} р. с налогом {Math.Round(Tax*sum,2)}");
        }
    }
}
