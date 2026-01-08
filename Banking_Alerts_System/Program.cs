namespace Banking_Alerts_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount bankAccount = new BankAccount(200000);
            SMSNotifier smsNotifier = new SMSNotifier();
            EmailNotifier emailNotifier = new EmailNotifier();
            SecurityDepartment securityDepartment = new SecurityDepartment();
            FraudDetector fraudDetector = new FraudDetector(5000);

            bankAccount.Deposited += smsNotifier.DepositeSMS;
            bankAccount.Deposited += emailNotifier.DepositeEmail;

            bankAccount.Withdrawn += smsNotifier.WithdrawSMS;
            bankAccount.Withdrawn += emailNotifier.WithdrawEmail;
            bankAccount.Withdrawn += fraudDetector.Detector;

            fraudDetector.SuspiciousActivityDetected += securityDepartment.SecurityAlart;

            Console.WriteLine("Welcome to Banking Alarts System");

            while (true)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter Option");

                var Option = Console.ReadLine();

                switch(Option)
                {
                    case "1":
                        Console.WriteLine("Enter deposit amount: ");
                        var Deposit = Console.ReadLine();

                        if (double.TryParse(Deposit,out double DepositAmount))
                        {
                            bankAccount.Deposite(DepositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid number!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter Withdraw amount: ");
                        var Withdraw = Console.ReadLine();
                        if (double.TryParse(Withdraw,out double WithdrawAmount))
                        {
                            bankAccount.Withdraw(WithdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid number!");
                        }
                        break;
                    case "3":
                        return;
                        

                }

            }
        }
    }
}
