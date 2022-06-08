using Facade.Subsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class MutualFund
    {
        private int accountNumber = 0;

        public MutualFund(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public void Buy(string tickerSymbol, int shares)
        {
            CashAccount account = new CashAccount(accountNumber);
            var equityFactory = EquityFactory.GetInstance();
            Equity equity = equityFactory.CreateEquity(tickerSymbol);

            decimal amount = equity.GetPrice() * shares;
            decimal balance = account.GetAccountBalance();

            if (balance >= amount)
            {
                account.Withdraw(amount);
                equity.Buy(shares);

                Console.WriteLine($"bought {shares} from {tickerSymbol} shares");
                Console.WriteLine($"New balance is {account.GetAccountBalance()}");

            } else
            {
                Console.WriteLine("Insufficient balance!");
            }

        }

    }
}
