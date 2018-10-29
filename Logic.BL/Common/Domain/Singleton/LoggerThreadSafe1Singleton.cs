using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.BL.Common.Domain.Singleton
{
    public class LoggerThreadSafe1Singleton
    {
        LoggerThreadSafe1Singleton()
        {
        }
        private static readonly object padlock = new object();
        private static LoggerThreadSafe1Singleton instance = null;
        public static LoggerThreadSafe1Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new LoggerThreadSafe1Singleton();
                    }
                    return instance;
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message + " - " + DateTime.Now);
        }
    }
}
