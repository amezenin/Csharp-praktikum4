using System;

namespace praktikum4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mootorsoiduk uusSoiduk = new Mootorsoiduk(80);
            uusSoiduk.Kiirenda();
            uusSoiduk.Kiirenda();
            uusSoiduk.Kiirenda();
            Console.WriteLine(uusSoiduk.ToString());
            uusSoiduk.Kiirenda(100);
            Console.WriteLine(uusSoiduk.hetkeSeis());
            uusSoiduk.Stop();
            Console.WriteLine(uusSoiduk.hetkeSeis());
            Console.ReadLine();

            Auto uusAuto = new Auto();
            uusAuto.Kiirenda(15);
            uusAuto.avaUksed();
            Console.WriteLine(uusAuto.hetkeSeis());
            uusAuto.Kiirenda(15);
            Console.WriteLine(uusAuto.hetkeSeis());
            uusAuto.SulgeUksed();
            uusAuto.Kiirenda(110);
            Console.WriteLine(uusAuto.hetkeSeis());
            Console.ReadLine();

            Veoauto uusVeoauto = new Veoauto();
            uusVeoauto.Kiirenda(80);
            Console.WriteLine(uusVeoauto.hetkeSeis());
            uusVeoauto.Stop();
            Console.WriteLine(uusVeoauto.hetkeSeis());
            uusVeoauto.hakkaKallutama();
            Console.WriteLine(uusVeoauto.hetkeSeis());
            Console.ReadLine();
        }
    }
}
