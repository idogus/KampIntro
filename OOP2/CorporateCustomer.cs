using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    public class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }

        public override string ToString()
        {
            return CompanyName;
        }
    }
}
