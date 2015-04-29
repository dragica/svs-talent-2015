using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using Registar.Common.Interfaces;
using Registar.DomainModel;
using Registar.BL.Contracts.Contracts;

namespace Registar.Repository.Interfaces
{
    public interface IBikeRepository:IRepository
    {
        IList<Bike> SearchBikes(BikeSearchCommand command);

        Bike CreateBikes(BikeCreateCommand command);
    }
}
