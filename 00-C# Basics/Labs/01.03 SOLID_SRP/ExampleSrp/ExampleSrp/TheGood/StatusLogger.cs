using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    class StatusLogger : ILogger
    {
        private static ILogger instance;

        private StatusLogger() { }

        public static ILogger GetStatusLogger()
        {
            if (instance == null)
            {
                instance = new StatusLogger();
            }
            return instance;            
        }
        public void Log(string stateChangeInfo)
        {
            Console.WriteLine("==============Car changed state:{0}", stateChangeInfo);
        }
    }
}
