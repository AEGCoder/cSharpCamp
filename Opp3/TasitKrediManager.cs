using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opp3
{
    public class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Tasit kredisi odeme plani hesaplandi");
        }

        public void BiseyYap()
        {
            System.Console.WriteLine("Tasit kredisi bisey yap");
        }   
    }
}