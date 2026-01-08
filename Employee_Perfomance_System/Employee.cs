using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Perfomance_System
{
    internal class Employee
    {
        public string Name { get; set; }
        public List<int> KPIs {  get; set; }

        public string Department {  get; set; }
    }
}
