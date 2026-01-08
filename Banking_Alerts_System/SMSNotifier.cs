using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Alerts_System
{
    internal class SMSNotifier
    {
        public void DepositeSMS(object? obj , TransactionEventArgs transactionEventArgs)
        {
            Console.WriteLine($"SMS: You deposited {transactionEventArgs.TransactionAmount}. New balance = {transactionEventArgs.NewBalance}.");
        }

        public void WithdrawSMS(object? obj, TransactionEventArgs transactionEventArgs)
        {
            Console.WriteLine($"SMS: Withdrawal of {transactionEventArgs.TransactionAmount}. New balance = {transactionEventArgs.NewBalance}.");
        }
    }
}
