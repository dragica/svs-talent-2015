using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.SOLID.ISP.Good
{
    public interface IRacingCar:ICar
    {
        /// <summary>
        /// Initializes the Nytro sistem
        /// </summary>
        void InitializeNytro();
    }
}
