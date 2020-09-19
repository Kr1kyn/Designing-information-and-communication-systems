using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    class BankPaymentHandler : PaymentHandler 
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Выполняем банковский перевод");
            else 
            if (Successor != null)
            {
                Console.WriteLine($"Перенаправляем запрос на {Successor}");
                Successor.Handle(receiver);
            }
        }

        public override string ToString()
        {
            return "Система банковских перводов";
        }
    }

    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true) 
                Console.WriteLine("Выполняем перевод через системы денежных переводов");
            else if (Successor != null)
            {
                Console.WriteLine($"Перенаправляем запрос на {Successor}");
                Successor.Handle(receiver);
            }  
        }
        public override string ToString()
        {
            return "Система денежных перводов";
        }
    }

    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("Выполняем перевод через систему PayPal");
            else if (Successor != null)
            {
                Console.WriteLine($"Перенаправляем запрос на {Successor}");
                Successor.Handle(receiver);
            }
        }
        public override string ToString()
        {
            return "Система PayPal";
        }
    }
}
