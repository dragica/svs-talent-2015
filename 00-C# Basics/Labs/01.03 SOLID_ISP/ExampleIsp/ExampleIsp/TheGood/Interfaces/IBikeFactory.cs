using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood.Interfaces
{
    public interface IBikeFactory
    {
        /// <summary>
        /// Produces the frame for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceFrameBike();

        /// <summary>
        /// Produce handles for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceHandlesBike();

        /// <summary>
        /// Produce gears for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceGearsBike();
    }
}
