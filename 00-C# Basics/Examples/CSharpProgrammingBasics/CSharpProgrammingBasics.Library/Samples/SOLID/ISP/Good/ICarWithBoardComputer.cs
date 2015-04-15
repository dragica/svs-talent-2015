using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.SOLID.ISP.Good
{
    public interface ICarWithBoardComputer:ICar
    {
        /// <summary>
        /// Initializes the onboard computer
        /// </summary>
        void InitializeComputer();
    }
}
