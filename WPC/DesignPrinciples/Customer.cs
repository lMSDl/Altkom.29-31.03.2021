using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class Customer : Entity
    {
        public Customer(int id)
        {
            Id = id;
            PaymentAccount =  new PaymentAccount();
        }

        public string CustomerName { get; set; }

        public PaymentAccount PaymentAccount { get; }
    }
}
