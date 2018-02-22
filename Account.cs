using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        protected uint accountNumber;
        protected int accountType;
        protected string accountDate;
        protected int accountSum;
        protected BankInformation information;

        public uint Number
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public int Type
        {
            set { accountType = value; }
        }

        public string Date
        {
            get { return accountDate; }
            set { accountDate = value; }
        }

        public int Sum
        {
            get { return accountSum; }
            set { accountSum = value; }
        }
    }
}
