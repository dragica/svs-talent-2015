using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Form Modify(Form form);

        [OperationContract]
        Form FindBigger(Form form1, Form form2);

        [OperationContract]
        bool SameAs(Form form1, Form form2);

        [OperationContract]
        double Area(Form form);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfExample.ContractType".
    [DataContract]
    public class Form
    {
        string type;
        private double width;
        private double height;

        [DataMember]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        [DataMember]
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        [DataMember]
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}
