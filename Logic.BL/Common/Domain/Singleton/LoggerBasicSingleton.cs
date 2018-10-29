using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.BL.Common.Domain.Singleton
{

    public class LoggerBasicSingleton
    {
        private static LoggerBasicSingleton instance;

        private LoggerBasicSingleton()
        {
        }

        public static LoggerBasicSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoggerBasicSingleton();
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