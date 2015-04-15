using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.SOLID.ISP.Good
{
    public interface ICar
    {
        /// <summary>
        /// Starts the car
        /// </summary>
        void Start();

        /// <summary>
        /// Stops the car
        /// </summary>
        void Stop();
        /// <summary>
        /// Locks the car
        /// </summary>
        void Lock();

        /// <summary>
        /// Unlocks the car
        /// </summary>
        void Unlock();
    }
}
