using System;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(true, false, false);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            paypalPaymentHandler.Successor = moneyPaymentHnadler;
            moneyPaymentHnadler.Successor = bankPaymentHandler;

            paypalPaymentHandler.Handle(receiver);
        }
    }
}
