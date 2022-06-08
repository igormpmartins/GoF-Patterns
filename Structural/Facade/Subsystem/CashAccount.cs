using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystem
{
    public class CashAccount: BankAccount
    {
        protected decimal balance = 1000;

        public CashAccount(int accountNumber): base(accountNumber)
        {

        }
        public override void Deposit(decimal amount) => balance += amount;
        public override decimal GetAccountBalance() => balance;
        public override void Withdraw(decimal amount) => balance -= amount;
    }
}
