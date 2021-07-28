using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    public class IndividualAccountFactory : AccountFactory
    {
        public override Account Create(int accountId, string accountOwner, decimal accountBalance) => new IndividualInvestmentAccount(accountId, accountOwner, accountBalance);
    }
}