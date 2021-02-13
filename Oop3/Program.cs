using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaceLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager };

            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
