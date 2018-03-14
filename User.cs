using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Bank
{
    public class User : Data
    {
        protected string fullName;
        protected bool isPremum;
        public DataRow user;
        public List<DataRow> account = new List<DataRow>();
        protected Dictionary<string, Account> accounts = new Dictionary<string, Account>();
        public User(string name, string pass)
        {
            if(this.Authorization(name, pass, ref user, ref account))
            {
                Console.WriteLine("You are log in");
            }
            else
            {
                Console.WriteLine("You are not log in");
            }
        }
    }
}
