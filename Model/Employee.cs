using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaymentCalculator.Model
{
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private string employeeType;
        private int workHours;
        private double hourlyRate;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string EmployeeType { get => employeeType; set => employeeType = value; }
        public int WorkHours { get => workHours; set => workHours = value; }
        public double HourlyRate { get => hourlyRate; set => hourlyRate = value; }

    }
}
