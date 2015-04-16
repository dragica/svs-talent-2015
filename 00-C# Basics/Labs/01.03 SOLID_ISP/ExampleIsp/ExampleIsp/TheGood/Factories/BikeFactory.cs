using ExampleIsp.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood.Factories
{
    public class BikeFactory : IFactory, IBikeFactory, IBikePaint
    {

        public int StartShift()
        {
            throw new NotImplementedException();
        }

        public int CloseShift()
        {
            throw new NotImplementedException();
        }

        public int StartProductionLane()
        {
            throw new NotImplementedException();
        }

        public int StopProductionLane()
        {
            throw new NotImplementedException();
        }

        public int ProduceBody()
        {
            throw new NotImplementedException();
        }

        public int ProduceEngine()
        {
            throw new NotImplementedException();
        }

        public int ProduceGears()
        {
            throw new NotImplementedException();
        }

        public int ProduceHeadLamps()
        {
            throw new NotImplementedException();
        }

        public int ProduceElectronics()
        {
            throw new NotImplementedException();
        }

        public int ProduceFrameBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceHandlesBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceGearsBike()
        {
            throw new NotImplementedException();
        }

        public int PaintBike(int paintColour)
        {
            throw new NotImplementedException();
        }
    }
}
