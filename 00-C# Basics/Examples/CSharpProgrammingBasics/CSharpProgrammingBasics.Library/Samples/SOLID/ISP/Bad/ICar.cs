using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpProgrammingBasics.Library.Samples.SOLID.ISP
{
    ///// <summary>
    ///// Initial interface
    ///// </summary>
    //public interface ICar
    //{
    //    /// <summary>
    //    /// Starts the car
    //    /// </summary>
    //    void Start();

    //    /// <summary>
    //    /// Stops the car
    //    /// </summary>
    //    void Stop();

    //    /// <summary>
    //    /// Locks the car
    //    /// </summary>
    //    void Lock();

    //    /// <summary>
    //    /// Unlocks the car
    //    /// </summary>
    //    void Unlock();


        
    //}

    /// <summary>
    /// Interface showing the polluted interface
    /// </summary>
    public interface ICar
    {
        /// <summary>
        /// Locks the car
        /// </summary>
        void Lock();

        /// <summary>
        /// Unlocks the car
        /// </summary>
        void Unlock();

        /// <summary>
        /// Initializes the onboard computer
        /// </summary>
        void InitializeComputer();

        /// <summary>
        /// Initializes the Nytro sistem
        /// </summary>
        void InitializeNytro();
    }
}
