using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood.Interfaces
{
    public interface IMotoPaint
    {
        /// <summary>
        /// Paints the motorcycle
        /// </summary>
        /// <param name="paintColour"></param>
        /// <returns></returns>
        int PaintMoto(int paintColour);
    }
}
