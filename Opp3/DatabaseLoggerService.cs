using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opp3
{
    public class DatabaseLoggerService : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Veritabanina loglandi");
        }
    }

   
   
}