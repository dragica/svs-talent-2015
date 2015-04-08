using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Form Modify(Form form)
        {
            if (form == null)
            {
                throw new ArgumentNullException("form");
            }
            
            form.Height *= 2;
            form.Width /= 2;

            return form;
        }

        public Form FindBigger(Form form1, Form form2)
        {
            if (form1.Width > form2.Width & form1.Height > form2.Height)
                return form1;
            else if (form1.Width < form2.Width & form1.Height < form2.Height)
                return form2;
            else if (form1.Width > form2.Width & form1.Height < form2.Height)
                return form1;
            else 
                return form2;
        }

        public bool SameAs(Form form1, Form form2)
        {
            if (form1.Width == form2.Width & form1.Height == form2.Height & form1.Type == form2.Type)
                return true;
            return false;       
        }

        public double Area(Form form)
        {
            return form.Width * form.Height;
        }
    }
}
