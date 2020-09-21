using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; } 
        public abstract void Handle(Receiver receiver);
    }
}
