using BankingClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AccountTests
{
    [TestClass]
    public class AccountUnitTests
    {
        private Bank _bank;
        CheckingAccount _checking;
        IndividualInvestmentAccount _individual;
        CorporateInvestmentAccount _corporate;


        [TestInitialize]
        public void Arrange()
        {
            _bank = new Bank("Merchant Bank");
            _checking = (CheckingAccount)new AccountCreator().ExecuteCreate(Actions.Checking, 1, "Merchant Bank", 1500);
            _individual = (IndividualInvestmentAccount)new AccountCreator().ExecuteCreate(Actions.Individual, 3, "Jerry Doe", 1500);
            _corporate = (CorporateInvestmentAccount)new AccountCreator().ExecuteCreate(Actions.Coporate, 2, "Jane Doe", 1500);

            _bank.Accounts.Add(_checking);
            _bank.Accounts.Add(_corporate);
            _bank.Accounts.Add(_individual);
        }

        //I feel that multiple asserts per test is ok as only one action is being tested per method and this upholds single responsibility

        //checking tests

        [TestMethod]
        public void CheckingDepositTest()
        {
            Assert.IsFalse(_checking.Deposit(0));
            Assert.IsTrue(_checking.Deposit(100));
        }

        [TestMethod]
        public void CheckingWithdrawTest()
        {
            Assert.IsFalse(_checking.Withdraw(0));
            Assert.IsFalse(_checking.Withdraw(10000));
            Assert.IsTrue(_checking.Withdraw(100));
        }

        [TestMethod]
        public void TransferCheckingToIndividualTest()
        {
            Assert.IsFalse(_checking.Transfer(_individual, 0));
            Assert.IsTrue(_checking.Transfer(_individual, 100));
        }

        [TestMethod]
        public void TransferCheckingToCorporateTest()
        {
            Assert.IsFalse(_checking.Transfer(_corporate, 0));
            Assert.IsFalse(_checking.Transfer(_corporate, 10000));
            Assert.IsTrue(_checking.Transfer(_corporate, 100));
        }

        //corporate tests

        [TestMethod]
        public void CorporateDepositTest()
        {
            Assert.IsFalse(_corporate.Deposit(0));
            Assert.IsTrue(_corporate.Deposit(100));
        }

        [TestMethod]
        public void CorporateWithdrawTest()
        {
            Assert.IsFalse(_corporate.Withdraw(0));
            Assert.IsFalse(_corporate.Withdraw(10000));
            Assert.IsTrue(_corporate.Withdraw(100));
        }

        [TestMethod]
        public void CorporateCheckingToIndividualTest()
        {
            Assert.IsFalse(_corporate.Transfer(_individual, 0));
            Assert.IsFalse(_corporate.Transfer(_individual, 10000));
            Assert.IsTrue(_corporate.Transfer(_individual, 100));
        }

        [TestMethod]
        public void TransferCorporateToCheckingTest()
        {
            Assert.IsFalse(_corporate.Transfer(_checking, 0));
            Assert.IsFalse(_corporate.Transfer(_checking, 10000));
            Assert.IsTrue(_corporate.Transfer(_checking, 100));
        }

        //individual tests

        [TestMethod]
        public void IndividualDepositTest()
        {
            Assert.IsFalse(_individual.Deposit(0));
            Assert.IsTrue(_individual.Deposit(100));
        }

        [TestMethod]
        public void IndividualWithdrawTest()
        {
            Assert.IsFalse(_individual.Withdraw(0));
            Assert.IsFalse(_individual.Withdraw(1001));
            Assert.IsFalse(_individual.Withdraw(10000));
            Assert.IsTrue(_individual.Withdraw(100));
        }

        [TestMethod]
        public void IndividualCheckingToCorporateTest()
        {
            Assert.IsFalse(_individual.Transfer(_corporate, 0));
            Assert.IsFalse(_individual.Transfer(_corporate, 10000));
            Assert.IsTrue(_individual.Transfer(_corporate, 100));
        }

        [TestMethod]
        public void IndividualCorporateToCheckingTest()
        {
            Assert.IsFalse(_individual.Transfer(_checking, 0));
            Assert.IsFalse(_individual.Transfer(_checking, 10000));
            Assert.IsTrue(_individual.Transfer(_checking, 100));
        }
    }
}