using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Alerts_System
{
    internal class TransactionEventArgs:EventArgs
    {
        public double TransactionAmount { get; set; }

        public double NewBalance { get; set; }

        public DateTime TransactionTime { get; set; }

        public TransactionEventArgs(double transactionamount , double newbalance, DateTime transactiontime)
        {
            TransactionAmount = transactionamount;
            NewBalance = newbalance;
            TransactionTime = transactiontime;
        }

    }
}
