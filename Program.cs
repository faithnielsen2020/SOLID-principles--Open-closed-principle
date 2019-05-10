using EmployeePaymentCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaymentCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var salaryCalculation = new List<EmployeeBaseSalaryCalculator>
            {
                new FullTimeEmpSalaryCalculator(new Employee{ Id= 100, FirstName = "John", LastName="Doe", EmployeeType="fulltime", HourlyRate=150.22, WorkHours=160 }),
                new FullTimeEmpSalaryCalculator(new Employee{ Id= 101, FirstName = "Jenny", LastName="Louis", EmployeeType="fulltime", HourlyRate=150.22, WorkHours=158 }),
                new PartTimeEmpSalaryCalculator(new Employee{ Id= 102, FirstName = "Marcus", LastName="Michael", EmployeeType="parttime", HourlyRate=120.50, WorkHours=100 }),
                new PartTimeEmpSalaryCalculator(new Employee{ Id= 103, FirstName = "Veronica", LastName="Smith", EmployeeType="parttime", HourlyRate=100.45, WorkHours=80 }),
                new HourlyEmpSalaryCalculator(new Employee{ Id= 104, FirstName = "Jack", LastName="Daniels", EmployeeType="", HourlyRate=180.18, WorkHours=40 }),
                new HourlyEmpSalaryCalculator(new Employee{ Id= 105, FirstName = "Gabriella", LastName="Lambert", EmployeeType="fulltime", HourlyRate=180.18, WorkHours=150 })
            };

            var calculator = new SalaryCalculator(salaryCalculation);
            Console.WriteLine("Total salary of all Employees: " + calculator.CalculateTotalsalary());

            Console.ReadLine();
        }
    }
}
