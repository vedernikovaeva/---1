using System;
using System.Collections.Generic;

namespace МКР_ШП
{
	public class PaymentLog
	{
        private static PaymentLog instance;

        private List<Payment> payments;

        private PaymentLog()
        {
            payments = new List<Payment>();
        }

        public static PaymentLog Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PaymentLog();
                }
                return instance;
            }
        }

        public void AddPayment(decimal amount, DateTime date)
        {
            payments.Add(new Payment(amount, date));
        }

        public void DisplayPayments()
        {
            Console.WriteLine("Лог платежів: ");
            foreach (var payment in payments)
            {
                Console.WriteLine($"Сума: {payment.Amount}, Дата: {payment.Date}");
            }
        }

        public decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (var payment in payments)
            {
                total += payment.Amount;
            }
            return total;
        }
    }


	public class Payment
	{
        public decimal Amount { get; }
        public DateTime Date { get; }

        public Payment(decimal amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}

