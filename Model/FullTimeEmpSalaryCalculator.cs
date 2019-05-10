using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaymentCalculator.Model
{
    public class FullTimeEmpSalaryCalculator : EmployeeBaseSalaryCalculator
    {
        public FullTimeEmpSalaryCalculator(Employee fullTimeEmployee) : base(fullTimeEmployee)
        {
        }

        public override double CalculateSalary()
        {
            double result;
            double percentage;
            percentage = (BaseEmployee.HourlyRate * BaseEmployee.WorkHours)* 0.02;
            result = (BaseEmployee.HourlyRate * BaseEmployee.WorkHours) + percentage;
            return result;

        }
    }
}
