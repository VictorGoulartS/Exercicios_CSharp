using System;
using Ex20Interfaces.Services;

namespace Ex20Interfaces.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
            return amount * months * 0.01;
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
