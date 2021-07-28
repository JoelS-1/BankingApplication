using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    public class IndividualInvestmentAccount : Account
    {

        public IndividualInvestmentAccount(int accountId, string accountOwner, decimal accountBalance)
        {
            AccountId = accountId;
            AccountOwner = accountOwner;
            AccountBalance = accountBalance;
        }

        public override bool Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount <= 0) return false;
                else if (AccountBalance < withdrawAmount) return false;
                    else if (withdrawAmount > 1000) return false;

            decimal startingBalance = AccountBalance;
            AccountBalance -= withdrawAmount;

            if (AccountBalance < startingBalance) return true;
            return false;

        }
    }
}
