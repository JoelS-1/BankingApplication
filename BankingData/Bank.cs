using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    public class Bank
    {
        public string Name;
        public List<Account> Accounts { get; set; }

        public Bank(string name)
        {
            Name = name;
            Accounts = new List<Account>();
        }
    }
}