using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;



namespace Bank
{
    public class Deposit : Account
    {
        protected double balance;
        protected double percentAdding;
        protected double withdrawSum;
        protected DateTime withdrawDate;
        
        public Deposit(XElement item)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            this.dateReg = (DateTime)item.Element("reg");
            this.nameAccount = (string)item.Element("name");
            this.balance = (double)item.Element("balance");
            this.percentAdding = (double)item.Element("adding");
            this.withdrawDate = (DateTime)item.Element("withdrawDate");
            this.withdrawSum = (double)item.Element("withdrawSum");
        }

        public Deposit(string nameAccount, double balance, double percentAdding)
        {
            this.dateReg = DateTime.Today;
            this.nameAccount = nameAccount;
            this.balance = balance;
            this.percentAdding = percentAdding;
            this.withdrawDate = this.dateReg.AddYears(2);
            this.withdrawSum = balance + ((balance / 10) * 2);
        }
    
        public double Balance { get { return balance; } set { this.balance = value; } }
        public double PercentAdding { get { return percentAdding; } }
        public double WithdrawSum { get { return withdrawSum; } }
        public DateTime WithdrawDate { get { return withdrawDate; } }
    }
}
