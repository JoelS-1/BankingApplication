using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    //abstract class with virtual methods to easily override account methods if more buisness logic is needed in the future
    //methods built robustly with true false statements for easier unit testing without needing to access protected properties
    public abstract class Account
    {
        protected int AccountId;
        protected string AccountOwner;
        protected decimal AccountBalance;

        public virtual bool Deposit(decimal depositAmount)
        {
            if (depositAmount <= 0) return false;

            decimal startingBalance = AccountBalance;
            AccountBalance += depositAmount;

            if (AccountBalance > startingBalance) return true;

            return false;
        }
        public virtual bool Withdrawal(decimal withdrawAmount)
        {
            if (withdrawAmount <= 0) return false;
                else if (AccountBalance < withdrawAmount) return false;

            decimal startingBalance = AccountBalance;
            AccountBalance -= withdrawAmount;

            if (AccountBalance < startingBalance) return true;
            return false;
        }

        public virtual bool Transfer(Account destinationAccount, decimal transferAmount)
        {
            if (transferAmount <= 0) return false;
                else if (AccountBalance < transferAmount) return false;

            decimal originStartingBalance = AccountBalance;
            decimal destinationStartingBalance = destinationAccount.AccountBalance;

            AccountBalance -= transferAmount;
            destinationAccount.AccountBalance += transferAmount;

            if (AccountBalance < originStartingBalance && destinationAccount.AccountBalance > destinationStartingBalance) return true;
            return false;
        }
    }
}
