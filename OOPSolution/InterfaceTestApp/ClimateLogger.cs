using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    class ClimateLogger : ILogger //Ver 1.0개발
    {
        public void WriteError(string error)
        {
            throw new NotImplementedException();
        }

        public void writeLog(string weather)
        {
            Console.WriteLine($"날씨로그 [{DateTime.Now.ToShortDateString()}] : 현재날씨 {weather}");
        }
    }
}
