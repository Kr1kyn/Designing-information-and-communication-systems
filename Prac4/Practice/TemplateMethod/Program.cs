using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression val = new ArithmeticProgression(0, 100, 6);
            val.TemplateMethod();
        }
    }
}
