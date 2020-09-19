using System;

namespace TemplatePaying
{
    class Program
    {
        static void Main(string[] args)
        {
            Paying paying1 = new CashPayment("Видеокарта", 45000);
            paying1.Pay();

            Paying paying2 = new PaymentWithElectronicMoney("Процессор", 32000,1.1);
            paying2.Pay();
        }
    }
}
