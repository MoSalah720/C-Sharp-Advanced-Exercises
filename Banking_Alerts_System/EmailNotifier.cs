using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Alerts_System
{
    internal class EmailNotifier
    {
        public void DepositeEmail(object? obj, TransactionEventArgs transactionEventArgs)
        {
            Console.WriteLine($"Email: You deposited {transactionEventArgs.TransactionAmount}. New balance = {transactionEventArgs.NewBalance}.");
        }

        public void WithdrawEmail(object? obj, TransactionEventArgs transactionEventArgs)
        {
            Console.WriteLine($"Email: Withdrawal of {transactionEventArgs.TransactionAmount}. New balance = {transactionEventArgs.NewBalance}.");
        }
    }
}
