using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool DeletePaymentAccount(PaymentAccount paymentAccount)
        {
            return PaymentAccounts.Remove(paymentAccount);
        }

        public PaymentAccount FindAccountByAllowedDebit(float allowedDebit)
        {
            return PaymentAccounts.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int paymentAccountId, float amount)
        {
            var account = PaymentAccounts.SingleOrDefault(x => x.Id == paymentAccountId);
            if (account == null)
            {
                return false;
            }

            if (account.Incomes - account.Outcomes + account.AllowedDebit < amount)
            {
                return false;
            }

            account.Outcomes += amount;
            return true;
        }

        public void Fund(int paymentAccountId, float amount)
        {
            var customer = PaymentAccounts.Where(x => x.Id == paymentAccountId).SingleOrDefault();
            if (customer == null)
            {
                return;
            }

            customer.Incomes += amount;
        }

        public float? GetBalance(int paymentAccountId)
        {
            var customer = PaymentAccounts.Where(x => x.Id == paymentAccountId).SingleOrDefault();
            return customer?.Incomes - customer?.Outcomes;
        }
    }
}
