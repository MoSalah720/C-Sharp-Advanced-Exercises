using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Alerts_System
{
    internal class BankAccount
    {
        private double Balance { get; set; }

        public string ClientName { get; set; }

        public BankAccount(double balance)
        {
            Balance = balance;
        }

        public event EventHandler<TransactionEventArgs> Deposited;

        public event EventHandler<TransactionEventArgs> Withdrawn;

        public event EventHandler<FraudEventArgs> SuspiciousActivityDetected;

        public void Deposite(double  Amount)
        {
            Balance += Amount;

            Deposited?.Invoke(this, new TransactionEventArgs(Amount, Balance, DateTime.Now));
        }

        public void Withdraw(double Amount)
        {

            if (Amount > Balance)
            {
                Console.WriteLine("The Amount that you want to withdraw exceed the your balance");
                return;
            }
            Balance -= Amount;

            Withdrawn?.Invoke(this, new TransactionEventArgs(Amount, Balance, DateTime.Now));

           

        }

    }
}
