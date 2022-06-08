using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystem
{
    public abstract class BankAccount
    {
        private int accountNumber = 0;

        public BankAccount(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public abstract decimal GetAccountBalance();
        public abstract void Withdraw(decimal amount);
        public abstract void Deposit(decimal amount);

    }
}
