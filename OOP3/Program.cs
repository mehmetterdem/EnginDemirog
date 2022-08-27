using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKredi = new İhtiyacKredi();
            IKrediManager tasıtKredi = new TasıtKredi();
            IKrediManager konutKredi = new KonutKredi();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasıtKredi,new FileLoggerManager());

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKredi,
                tasıtKredi,
                konutKredi
            };
           // basvuruManager.KrediÖnBilgilendirmesiYap(krediler);

        }
    }
}
