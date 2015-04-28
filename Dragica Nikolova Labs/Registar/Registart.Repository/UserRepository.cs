using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.Repository.Interfaces;
using log4net;
using log4net.Config;
using System.Reflection;
using Registar.Common;

namespace Registar.Repository
{
    internal class UserRepository:IUserRepository
    {
        private readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly ILog log1 = LogManager.GetLogger("NewLogger");
        //Logging.LogWarn("This is a warn message");
        public bool UpdateProfileData()
        {
            throw new NotImplementedException();
        }
    }
}
