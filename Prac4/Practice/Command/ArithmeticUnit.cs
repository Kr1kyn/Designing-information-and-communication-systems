using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ArithmeticUnit
    {
        public double Register { get; private set; }
        public void Run(char operationCode, double operand)
        {
            switch (operationCode)
            {
                case '+': Register += operand; break;
                case '-': Register -= operand; break;
                case '*': Register *= operand; break;
                case '/': Register /= operand; break;
            }
        }
    }
}
