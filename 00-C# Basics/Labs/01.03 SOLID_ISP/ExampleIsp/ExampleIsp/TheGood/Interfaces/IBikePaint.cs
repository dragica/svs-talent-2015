using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood.Interfaces
{
    public interface IBikePaint
    {
        /// <summary>
        /// Paints the bike
        /// </summary>
        /// <param name="paintColour"></param>
        /// <returns></returns>
        int PaintBike(int paintColour);
    }
}
