using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new PersonalFinanceCreditManager();
            ICreditManager tasitKrediManager = new VehicleCreditManager();
            ICreditManager konutKrediManager = new HousingCreditManager();

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.Recource(tasitKrediManager, new FileLoggerManager());

            IList<ICreditManager> creditManagers = new List<ICreditManager>()
            {
                ihtiyacKrediManager,
                konutKrediManager
            };

            recourseManager.MakeCreditPreNotification(creditManagers);
        }
    }
}
