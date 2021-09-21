using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        protected string nameAccount;
        protected DateTime dateReg;

        public string NameAccount { get { return nameAccount; } set { this.nameAccount = value; } }
        public DateTime DateReg { get { return dateReg; } }
    }
}
