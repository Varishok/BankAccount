using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Deposit : Account
    {
        protected float balance;
        protected float percentAdding;
        protected DateTime withdrawDate;
        protected DateTime withdrawSum;
    }
}
