
namespace Employee_Perfomance_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employees performance system .");

            List<Employee>Employees=new List<Employee>();
            while (true)
            {
                Console.WriteLine("Please enter your name ! & if you want to exit please enter 'done'");
                string UserName = Console.ReadLine();
                if (UserName=="done")
                {
                    break;
                }

                Console.WriteLine("Please enter your Department ! ");
                string UserDepartment = Console.ReadLine();
                List<int>UserKPIs = new List<int>();
                Console.WriteLine("Please enter your KPIs (5)");
                for (int i = 0; i < 5; i++)
                {
                   int KPIsValue = int.Parse(Console.ReadLine()); 
                    UserKPIs.Add(KPIsValue);
                }

                Employee employee= new Employee();
                employee.Name = UserName;
                employee.KPIs = UserKPIs;
                employee.Department = UserDepartment;
                Employees.Add(employee);
                Console.WriteLine($"Employee added successfully Name {UserName}, KPIs count= {UserKPIs.Count}and Department is {UserDepartment}");

            }

            PerformanceSystem performanceSystem = new PerformanceSystem();
            performanceSystem.EvaluatePerformance(Employees, CalculateScore, CheckIfExcellant, DisplayInfo);
        }

        private static void DisplayInfo(Employee employee, double Score, bool IsExcellant)
        {
            string Evaluation = IsExcellant ? "Yes" : "No"; 
            Console.WriteLine($"Name :{employee.Name} - Score :{Score} - IsExcellant :{Evaluation}");
        }

        private static bool CheckIfExcellant(double Score)
        {
            return Score >= 85;
        }

        private static double CalculateScore(List<int> KPIs)
        {
            return KPIs.Sum()/KPIs.Count;
        }
    }
}
