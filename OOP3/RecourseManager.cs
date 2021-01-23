using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class RecourseManager
    {
        public void Recource(ICreditManager creditManager, ILoggerService loggerService)
        {
            Console.WriteLine("===========Başvuru alındı===============");
            creditManager.Calculate();
            loggerService.Log();
        }
        public void MakeCreditPreNotification(IList<ICreditManager> creditManagers)
        {
            Console.WriteLine("=============Ön bilgilendirme!===============");
            foreach (var creditManager in creditManagers)
            {
                creditManager.Calculate();
            }
        }
    }
}
