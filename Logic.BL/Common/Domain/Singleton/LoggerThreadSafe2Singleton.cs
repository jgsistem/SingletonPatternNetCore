using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.BL.Common.Domain.Singleton
{
    public class LoggerThreadSafe2Singleton
    {
        LoggerThreadSafe2Singleton()
        {
        }
        private static readonly object padlock = new object();
        private static LoggerThreadSafe2Singleton instance = null;
        public static LoggerThreadSafe2Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new LoggerThreadSafe2Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message + " - " + DateTime.Now);
        }
    }
}
