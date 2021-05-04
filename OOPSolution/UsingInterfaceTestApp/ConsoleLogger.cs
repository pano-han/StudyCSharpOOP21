using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class ConsoleLogger : ILogger
    { 
        public DateTime currentDate { get; set; }
        public ConsoleLogger()
        {  
        }
        public ConsoleLogger(DateTime currentDate)
        {
            this.currentDate = currentDate;
        }
        public void WriteLog(string message)
        {
            Console.WriteLine($"콘솔로그 : {this.currentDate} --> {message}");
        }
    }
}
