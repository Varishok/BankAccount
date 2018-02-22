using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //методы с вкладами(открыть, закрыть). Баланс общий.

        private string fullName;
        private string birthDate;
        private bool premium;
        public List<Credit> credits;
        public List<Deposit> deposits;

        public Client(string name, string date, bool prem)
        {
            fullName = name;
            birthDate = date;
            premium = prem;
        }

        public string GetFullName()
        {
            return fullName;
        }

        public string GetBirthDate()
        {
            return birthDate;
        }

        public string GetPremium()
        {
            if (premium)
            {
                return "Премиальный клиент";
            }
            else
            {
                return "Стандартный клиент";
            }
        }


    }
}
