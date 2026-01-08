using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Alerts_System
{
    internal class FraudEventArgs:EventArgs
    {
        public double SuspiciousAmount {  get; set; }

        public double CurrentBalance { get; set; }

        public string SuspiciousReason {  get; set; }

        public FraudEventArgs(double suspiciousamount , double currentbalance , string suspiciousreason)
        {
            SuspiciousAmount = suspiciousamount;
            CurrentBalance = currentbalance;
            SuspiciousReason = suspiciousreason;
        }
    }
}
