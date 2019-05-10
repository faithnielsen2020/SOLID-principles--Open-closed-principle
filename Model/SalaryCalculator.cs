using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaymentCalculator.Model
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<EmployeeBaseSalaryCalculator> employeeCalculation;

        public SalaryCalculator(IEnumerable<EmployeeBaseSalaryCalculator> empCalculation)
        {
            employeeCalculation = empCalculation;
        }


        public double CalculateTotalsalary()
        {
            double totalsumOfSalaries = 0d;
            foreach (var item in employeeCalculation)
            {
                totalsumOfSalaries += item.CalculateSalary();
            }
            return totalsumOfSalaries;
        }
    }
}
