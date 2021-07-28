using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    public class CorporateInvestmentAccount : Account
    {

        public CorporateInvestmentAccount(int accountId, string accountOwner, decimal accountBalance)
        {
            AccountId = accountId;
            AccountOwner = accountOwner;
            AccountBalance = accountBalance;
        }
    }
}
