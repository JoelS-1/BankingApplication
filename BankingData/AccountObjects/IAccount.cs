using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    //interface implementation for easy type casting on creation of new accounts
    //inherited by abstract generic account class to provide protected properties further down the line
    public interface IAccount
    {
        bool Deposit(decimal depositAmount);
        bool Withdraw(decimal withdrawAmount);
    }
}
