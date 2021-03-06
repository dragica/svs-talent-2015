﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using Registar.Common;
using Registar.DataLayer;
using Registar.DataLayer.Interfaces;
using Registar.Repository.Interfaces;
using Registar.DomainModel;
using Registar.BL.Contracts.Contracts;

namespace Registar.Repository
{
    internal class BikeRepository:IBikeRepository
    {
        public Bike CreateBikes(BikeCreateCommand command)
        {
            //
            using (var context = DataContextManager.CreateContext<RegistarDbContext>())
            {
                Bike bike = new Bike();
                bike.BikeOwnerId = command.BikeOwnerId;
                bike.RegNumber = command.RegNumber;
                bike.Colour = command.Colour;
                bike.Producer = command.Producer;
                bike.Model = command.Model;

                context.Bikes.Add(bike);
                context.SaveChanges();

                return bike;
            }
        }

        public IList<DomainModel.Bike> SearchBikes(BikeSearchCommand command)
        {
            //
            Logging.LogWarn("===============StarSearchBike=============");
            using (var context =  DataContextManager.CreateContext<IRegistarContext>())
            {
                var qry = 
                    from b in context.Bikes
                    select b;

                if (!string.IsNullOrEmpty(command.Colour))
                {
                    qry = qry.Where(x => x.Colour == command.Colour);
                }
                if (!string.IsNullOrEmpty(command.Producer))
                {
                    qry = qry.Where(x => x.Producer == command.Producer);
                }
                //
                int take;
                int skip;
                CalculateTakeSkip(command.PageSize, command.PageIndex,out take,out skip);
                qry = qry.OrderBy(x => x.BikeId).Take(take).Skip(skip);

                return qry.ToList();
            }
            Logging.LogWarn("===============EndSearchBike===============");
        }

        private void CalculateTakeSkip(int pageSize, int pageIndex, out int take, out int skip)
        {
            skip = 0;
            if (pageSize == 0)
                pageSize = 25;
            take = pageSize;
            if (pageIndex != 0)
                skip = (pageIndex - 1)*take;
        }        
    }
}
