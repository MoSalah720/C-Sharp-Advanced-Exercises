using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Perfomance_System
{
    internal class PerformanceSystem
    {
        public void EvaluatePerformance(List<Employee>Employees,Func<List<int>,double>CalculateScore,
            Predicate<double>CheckIfExcellant,Action<Employee,double,bool>DisplayInfo
            )
        {
            foreach (var employee in Employees)
            {
                double Score = CalculateScore(employee.KPIs);
                bool IsExcellant = CheckIfExcellant(Score);
                DisplayInfo(employee,Score ,IsExcellant);

            }
        }
    }
}
