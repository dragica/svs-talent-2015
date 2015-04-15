using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.SOLID.SRP.Good
{
    public class CarPure
    {
        public void Lock()
        {
            try
            {
                //
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error locking the car!");
            }
        }

        public void Unlock()
        {
            try
            {
                //
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error unlocking the car!");
            }

        }
    }
}
