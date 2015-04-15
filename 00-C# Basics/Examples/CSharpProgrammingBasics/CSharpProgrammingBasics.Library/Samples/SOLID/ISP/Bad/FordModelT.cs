using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.SOLID.ISP.Bad
{
    public class FordModelT:ICar
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Lock()
        {
            throw new NotImplementedException();
        }

        public void Unlock()
        {
            throw new NotImplementedException();
        }

        //public void InitializeComputer()
        //{
        //    throw new NotImplementedException();
        //}

        //public void InitializeNytro()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
