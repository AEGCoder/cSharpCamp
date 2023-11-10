using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opp3
{
    public class KonutKrediManager : IKrediManager
    {
          public void Hesapla()
        {
            Console.WriteLine("Konut kredisi odeme plani hesaplandi");
        }

        public void BiseyYap()
        {
            System.Console.WriteLine("Konut kredisi bisey yap");
        } 
    }
}