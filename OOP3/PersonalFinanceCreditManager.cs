using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı!");

        }

        public void Onayla()
        {
            throw new NotImplementedException();
        }
    }
}
