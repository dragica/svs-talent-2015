using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.SOLID.SRP.Good
{
    public class CarUI:CarPure
    {
        public void DrawWeb()
        {
            Console.WriteLine("Draws the car for web.");
        }

        public void DrawMetro()
        {
            Console.WriteLine("Draws the car for metro style.");
        }

        public void DrawWin()
        {
            Console.WriteLine("Draw the car for windows app.");
        }
    }
}
