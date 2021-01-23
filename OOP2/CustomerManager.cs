using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // İş sınıfları - Business Classes
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            if (customer == null)
                return;
            Console.WriteLine($"{customer.ToString()} Eklendi!");
        }
    }
}
