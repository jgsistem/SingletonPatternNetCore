using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.BL.Common.Domain.Singleton
{
    public class LoggerThreadSafe4LazySingleton
    {
        private LoggerThreadSafe4LazySingleton()
        {
        }
        private static readonly Lazy<LoggerThreadSafe4LazySingleton> lazy = new Lazy<LoggerThreadSafe4LazySingleton>(() => new LoggerThreadSafe4LazySingleton());
        public static LoggerThreadSafe4LazySingleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message + " - " + DateTime.Now);
        }
    }
}
