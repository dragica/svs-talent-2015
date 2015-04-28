using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.Common.Interfaces;

namespace Registar.Common
{
    public static class DataContextManager
    {
        private static IContextFactory theFactory;

        public static TContext CreateContext<TContext>() where TContext : IdbContext
        {
            TContext result = theFactory.CreateContext<TContext>();
            return result;
        }

        public static void RegisterFactory(IContextFactory factory)
        {
            theFactory = factory;
        }
    }
}
