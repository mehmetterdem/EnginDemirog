using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
      public void BasvuruYap(IKrediManager krediManager,ILoggerService logger)
        {
            krediManager.Hesapla();
            logger.Log();
        }

        public void KrediÖnBilgilendirmesiYap(List<IKrediManager> Krediler)
        {
            foreach (var item in Krediler)
            {
                item.Hesapla();
            }
        }
    }
}
