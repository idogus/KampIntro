using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    public class IndividualCustomer : Customer
    {
        public string TCKN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
