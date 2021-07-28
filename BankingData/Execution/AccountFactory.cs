using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    public abstract class AccountFactory
    {
        public abstract Account Create(int accountId, string accountOwner, decimal accountBalance);
    }
}