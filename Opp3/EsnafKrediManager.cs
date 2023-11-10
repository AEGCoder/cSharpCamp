using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opp3
{
    public class EsnafKrediManager : IkrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi odeme plani hesaplandi");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
    
}