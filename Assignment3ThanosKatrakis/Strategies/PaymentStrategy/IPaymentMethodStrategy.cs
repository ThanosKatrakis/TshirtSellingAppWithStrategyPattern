using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3ThanosKatrakis.Strategies.PaymentStrategy
{
    interface IPaymentMethodStrategy
    {
        void Pay(decimal amount);
    }
}
