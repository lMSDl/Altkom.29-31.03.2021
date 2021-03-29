using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class PaymentAccount : Entity
    {
        public float Incomes { get; private set; }
        public float Outcomes { get; private set; }
        public float AllowedDebit { get; set; }

        public float Balance => Incomes - Outcomes;

        public bool Charge(float amount)
        {
            if (Balance + AllowedDebit < amount)
                return false;
            Outcomes += amount;
            return true;
        }

        public void Fund(float amount)
        {
            Incomes += amount;
        }
    }
}
