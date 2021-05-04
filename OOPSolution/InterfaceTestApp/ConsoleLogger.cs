﻿using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class ConsoleLogger : ILogger //Ver 1.0개발
    {
        public void WriteError(string error)
        {
            Debug.WriteLine ($"에러 { error}"); 
        }

        public void writeLog(string message)
        {
            Console.WriteLine($"로그 [{DateTime.Now}] : {message}");
        }
    }
}
