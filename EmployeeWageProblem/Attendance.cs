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

        public int CheckAttendance(string company, int empRatePerHour, int maxDaysInMonth, int maxHrs)
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

            Console.WriteLine("total Wage For:"+company + totalEmpWage);
            return totalEmpWage;
        }
    }
}
