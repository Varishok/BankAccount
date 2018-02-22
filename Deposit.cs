using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Deposit : Account
    {
        //минимальный срок. лимит выдачи, остаток. пополнить, снять-частично.

        public string Type
        {
            get { return "Deposit"; }
        }
    }
}
