using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class ExceptionLogger : ILogger
    {
        private static ILogger instance;

        private ExceptionLogger() { }

        public static ILogger GetExceptionLogger()
        {
            if (instance == null)
            {
                instance = new ExceptionLogger();
            }
            return instance;
        }

        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
