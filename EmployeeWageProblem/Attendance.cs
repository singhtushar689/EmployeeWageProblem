using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Attendance
    {
        public const int present = 1;
        public const int absent = 2;

        private string company;
        private int empRatePerHour;
        private int maxDaysInMonth;
        private int maxHrs;
        private int totalEmpWage;
        public Attendance(string company, int empRatePerHour, int maxDaysInMonth, int maxHrs)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.maxDaysInMonth = maxDaysInMonth;
            this.maxHrs = maxHrs;
        }
        public void CheckAttendance()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs < maxHrs && totalWorkingDays <= maxDaysInMonth)
            {
                Random random = new Random();
                int checkOption = random.Next(1, 4);
                switch (checkOption)
                {
                    case 1:
                        empHrs = 8;
                        Console.WriteLine("Employee is present Full-Time");
                        break;
                    case 2:
                        empHrs = 4;
                        Console.WriteLine("Employee is Present Part-Time");
                        break;
                    case 3:
                        empHrs = 0;
                        Console.WriteLine("Employee is absent");
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day: " + totalWorkingDays + " Emp Hours :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Wage For:" + this.company + "is " + totalEmpWage);
        }
        public string ToString()
        {
            return ("Total EmpWage for " + this.company + " is" + totalEmpWage);
        }
    }
}
