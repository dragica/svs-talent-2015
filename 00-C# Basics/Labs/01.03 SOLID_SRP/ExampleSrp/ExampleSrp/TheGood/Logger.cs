using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class Logger : ILogger
    {
        public virtual void Log(string msg)
        {
            Console.WriteLine("Generic logger");
        }
    }
}
