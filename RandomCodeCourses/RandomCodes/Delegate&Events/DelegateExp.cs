using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Delegate_Events
{
    public static class DelegateExp
    {

    }

    public delegate void OnBalanceDecreased(decimal balance);

    public class BankAccount
    {
        public decimal Balance { get; private set; }
        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public event OnBalanceDecreased OnBalanceDecreased;
        public void DecreaseBalance(decimal price)
        {
            Balance -= price;
            OnBalanceDecreased?.Invoke(price);
            //your code goes here
        }
    }

    public class User
    {
        public decimal Funds { get; private set; }

        public User(decimal cash, decimal moneyInBank)
        {
            Funds = cash + moneyInBank;
        }
        public void ReduceFunds(decimal balanceReduced)
        {
            Funds -= balanceReduced;
            //your code goes here
        }
    }



}
