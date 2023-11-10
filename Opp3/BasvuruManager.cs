using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opp3
{
    public class BasvuruManager
    {
            public void BasvuruYap(IkrediManager krediManager)
          
            {
                 krediManager.Hesapla();
            }


            public void KrediOnBilgilendirmesiYap( List<IkrediManager> krediler)
            {
              foreach (var kredi in krediler)
              {
                 kredi.Hesapla();
              }
            }
    }
}