using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePaying
{
    abstract class Paying
    {
        public double Sum { get; }
        public string Product { get; }

        public Paying(string product,double sum)
        {
            Product = product;
            Sum = sum;
        }

        public void Pay()
        {
            CheckSum();
            СhargeGoods(Sum);
            GetReceipt();
        }

        private void CheckSum()
        {
            Console.WriteLine($"Cтоимость товара составляет {Sum} р.");
        }

        protected abstract void СhargeGoods(double sum);

        private void GetReceipt()
        {
            Console.WriteLine($"Товар {Product} оплачен, в скором времени он поступит к вам.");
        }
    }
}
