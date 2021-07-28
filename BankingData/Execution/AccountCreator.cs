using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    public class AccountCreator
    {
        private readonly Dictionary<Actions, AccountFactory> _factories;

        public AccountCreator()
        {
            _factories = new Dictionary<Actions, AccountFactory>
            {
                {Actions.Checking, new CheckingAcountFactory() },
                {Actions.Coporate, new CorporateAccountFactory() },
                {Actions.Individual, new IndividualAccountFactory() }
            };
        }

        public Account ExecuteCreate(Actions action, int accountId, string accountOwner, decimal accountBalance) => _factories[action].Create(accountId, accountOwner, accountBalance);
    }
}