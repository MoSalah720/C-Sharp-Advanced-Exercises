using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Alerts_System
{
    internal class SecurityDepartment
    {
        public void SecurityAlart(object? obj , FraudEventArgs args)
        {
            Console.WriteLine($"SECURITY ALERT: Suspicious withdrawal of {args.SuspiciousAmount}. Reason: {args.SuspiciousReason}.");
        }
    }
}
