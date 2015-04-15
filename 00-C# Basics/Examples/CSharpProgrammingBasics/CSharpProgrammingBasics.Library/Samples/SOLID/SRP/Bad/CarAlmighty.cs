using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.SOLID.SRP.Bad
{
    /// <summary>
    /// This car knows how to do many things and violates the SingleResponsibilityPrinciple
    /// </summary>
    public class CarAlmighty
    {
        public void Lock()
        {
            Console.WriteLine("The car is now locked!");
        }


        public void Unlock()
        {
            Console.WriteLine("The car is not unlocked!");
        }

        //UI Specific
        public void DrawMetro()
        {
            Console.WriteLine("Draw the car shape on the phone!");
        }

        public void DrawWeb()
        {
            Console.WriteLine("Draw the car shape on the web!");            
        }

        public void DrawWin()
        {
            Console.WriteLine("Draw the car shape on Windows App!");            
        }
    }
}
