using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сложение");
            var calculator = new Calculator(); double result = 0;

            result = calculator.Add(5); Console.WriteLine(result);
            result = calculator.Add(4); Console.WriteLine(result);
            result = calculator.Add(3); Console.WriteLine(result);
            result = calculator.Redo(); Console.WriteLine(result);
            result = calculator.Undo(); Console.WriteLine(result);

            result = calculator.Undo(3); Console.WriteLine(result);
            result = calculator.Redo(3); Console.WriteLine(result);

            Console.WriteLine("Вычитание");
            var calculator1 = new Calculator();

            result = calculator1.Add(10); Console.WriteLine(result);
            result = calculator1.Sub(4); Console.WriteLine(result);
            result = calculator1.Sub(3); Console.WriteLine(result);
            result = calculator1.Redo(); Console.WriteLine(result);
            result = calculator1.Undo(); Console.WriteLine(result);

            result = calculator1.Undo(2); Console.WriteLine(result);
            result = calculator1.Redo(3); Console.WriteLine(result);

            Console.WriteLine("Умножение");
            var calculator2 = new Calculator();

            result = calculator2.Add(2); Console.WriteLine(result);
            result = calculator2.Mul(4); Console.WriteLine(result);
            result = calculator2.Mul(3); Console.WriteLine(result);
            result = calculator2.Redo(); Console.WriteLine(result);
            result = calculator2.Undo(); Console.WriteLine(result);

            result = calculator2.Undo(2); Console.WriteLine(result);
            result = calculator2.Redo(3); Console.WriteLine(result);

            Console.WriteLine("Вычитание");
            var calculator3 = new Calculator();

            result = calculator3.Add(10); Console.WriteLine(result);
            result = calculator3.Div(2); Console.WriteLine(result);
            result = calculator3.Div(5); Console.WriteLine(result);
            result = calculator3.Undo(); Console.WriteLine(result);
            result = calculator3.Redo(); Console.WriteLine(result);

            result = calculator3.Undo(2); Console.WriteLine(result);
            result = calculator3.Redo(2); Console.WriteLine(result);

        }
    }
}
