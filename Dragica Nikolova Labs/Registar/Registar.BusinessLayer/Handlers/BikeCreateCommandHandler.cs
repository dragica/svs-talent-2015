using Registar.BL.Contracts.Contracts;
using Registar.Common;
using Registar.DomainModel;
using Registar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Handlers
{
    public class BikeCreateCommandHandler : CommandHandlerBase<BikeCreateCommand,BikeCreateResult>
    {    
        protected override BikeCreateResult ExecuteCommand(BikeCreateCommand command)
        {
            IBikeRepository repo = RepositoryManager.CreateRepository<IBikeRepository>();

            BikeCreateResult result = new BikeCreateResult();
            result.Result = repo.CreateBikes(command) as Bike;
            result.IsSuccess = false;
            result.ValidationErrors = new List<string>();
            result.ValidationErrors.Add("Not valid owner id");

            IBikeRepository bikeRepo = RepositoryManager.CreateRepository<IBikeRepository>();
            //
            return result;
        }
    }
}
