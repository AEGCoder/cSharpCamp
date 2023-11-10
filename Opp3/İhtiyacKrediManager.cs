using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opp3
{
    public class IhtiyacKrediManager : IKrediManager
    {
          public void Hesapla()
        {
            Console.WriteLine("İhtiyac kredisi odeme plani hesaplandi");
        }

        public void BiseyYap()
        {
            System.Console.WriteLine("İhtiyac kredisi bisey yap");
        } 
    }
}