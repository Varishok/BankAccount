using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankInformation
    {
        private string name;
        private int percent;

        public BankInformation(string str, int per)
        {
            name = str;
            percent = per;
        }

        public void SetName(string str)
        {
            name = str;
        }

        public void SetPercent(int per)
        {
            percent = per;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPercent()
        {
            return percent;
        }
    }
}
