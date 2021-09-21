using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;

namespace Bank
{
    public class Credit : Account
    {
        protected double debt;
        protected double nextPay;
        protected DateTime dateNext;
        protected DateTime dateEnd;

        public Credit(XElement item)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            this.dateReg = (DateTime)item.Element("reg");
            this.nameAccount = (string)item.Element("name");
            this.debt = (double)item.Element("debt");
            this.nextPay = (double)item.Element("nextPay");
            this.dateNext = (DateTime)item.Element("dateNext");
            this.dateEnd = (DateTime)item.Element("dateNext");
        }

        public double Debt { get { return debt; } }
        public double NextPay { get { return nextPay; } }
        public DateTime DateNext { get { return dateNext; } }
        public DateTime DateEnd { get { return dateEnd; } }
    }
}
