using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Credit : Account
    {
        protected float debt;
        protected float nextPay;
        protected DateTime dateNext;
        protected DateTime dateEnd;
    }
}
