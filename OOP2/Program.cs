using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customerOne = new IndividualCustomer();
            customerOne.Id = 1;
            customerOne.Name = "İbrahim";
            customerOne.Surname = "Doğuş";
            customerOne.TCKN = "222222222222";
            customerOne.CustomerNumber = "12345";

            CorporateCustomer customerTwo = new CorporateCustomer();
            customerTwo.Id = 2;
            customerTwo.CustomerNumber = "54234";
            customerTwo.CompanyName = "Doğuş Yazılım";
            customerTwo.TaxNumber = "12341050";

            Customer customer = customerOne;
            

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customerTwo);


        }
    }
}
