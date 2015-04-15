using Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Party
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string IdentificationNumber { get; set; }
        public TransactionAccount TransactionAccount { get; set; }
        public Account[] Accounts;
    }
}
