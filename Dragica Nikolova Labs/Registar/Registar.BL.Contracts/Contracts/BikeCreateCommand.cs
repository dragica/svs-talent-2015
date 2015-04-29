using Registar.BusinessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BL.Contracts.Contracts
{
    public class BikeCreateCommand : Command
    {
        public int BikeOwnerId { get; set; }

        public string RegNumber { get; set; }

        public string Producer { get; set; }

        public string Colour { get; set; }

        public string Model { get; set; }

    }
}
