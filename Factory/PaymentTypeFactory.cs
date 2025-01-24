using Factory.Classes;
using Factory.Inferface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PaymentTypeFactory
    {
        public IPaymentType Create(string paymentType) 
        {
            if (paymentType.Equals("1"))
            {
                return new CreditCardPaymentType();
            }
            else if (paymentType.Equals("2"))
            {
                return new DebitCardPaymentType();
            }
            return new CreditCardPaymentType();
        }
    }
}
