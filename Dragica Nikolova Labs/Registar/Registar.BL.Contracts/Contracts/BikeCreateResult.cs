using Registar.BusinessLayer.Contracts;
using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BL.Contracts.Contracts
{
    public class BikeCreateResult : CommandResult
    {
        public Bike Result { get; set; }
    }
}
