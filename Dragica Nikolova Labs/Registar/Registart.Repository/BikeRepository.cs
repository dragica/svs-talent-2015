using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.Common;
using Registar.DataLayer;
using Registar.Repository.Interfaces;
using Registar.Common.Interfaces;

namespace Registar.Repository
{
    internal class BikeRepository:IBikeRepository
    {
        public IList<DomainModel.Bike> SearchBikes()
        {
            //
            Logging.LogWarn("===============StarSearchBike=============");
            using (var context =  DataContextManager.CreateContext<IdbContext>())
            {

            }
            Logging.LogWarn("===============EndSearchBike===============");
        }
    }
}
