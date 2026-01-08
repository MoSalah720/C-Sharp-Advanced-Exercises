using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Alerts_System
{
    internal class FraudDetector
    {
        public event EventHandler<FraudEventArgs> SuspiciousActivityDetected;

        private double SuspisiousAmount {  get; set; }
        public FraudDetector(double suspisiousamount)
        {
            SuspisiousAmount = suspisiousamount;
        }

        public void Detector(object? obj, TransactionEventArgs args)
        {
           

            if (args.TransactionAmount>SuspisiousAmount)
            {
                string SuspiciousReason =  "Large Transaction";
                SuspiciousActivityDetected?.Invoke(this, new FraudEventArgs(args.TransactionAmount, args.NewBalance, SuspiciousReason));
            }

        }


    }
}
