using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Renault reno = new Renault("Рено", "Renault LOGAN Active", 499.0);
            Print(reno);
            AutoBase myreno = new MediaNAV(reno, "Навигация");
            Print(myreno);
            AutoBase newmyReno = new SystemSecurity(new MediaNAV(reno, "Навигация"), "Безопасность");
            Print(newmyReno);

            var nisan = new Nisan("Нисан", "Nissan Maxima", 450);
            Print(nisan);
            AutoBase mediaNissan = new AudioSystem(nisan, "Аудиосистема");
            Print(mediaNissan);
            AutoBase AutoMediaNissan = new AutopilotSystem(mediaNissan, "Автопилот");
            Print(AutoMediaNissan);
            AutoBase AutoMediaSecurityNissan = new SystemSecurity(AutoMediaNissan, "Безопасность");
            Print(AutoMediaSecurityNissan);

        }

        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
    }
}
