﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("sms Loglandı.");
        }
    }
}
