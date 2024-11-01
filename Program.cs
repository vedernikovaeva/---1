using System;
using System.Diagnostics;

namespace МКР_ШП
{
    class Program
    {
        static void Main()
        {
            PaymentLog log = PaymentLog.Instance;

            log.AddPayment(1000m, DateTime.Now);
            log.AddPayment(200.75m, DateTime.Now);

            log.DisplayPayments();

            Console.WriteLine($"Загальна сума: {log.GetTotalAmount()}");
        }
    }
}
