using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Attendance
    {
        public void CheckAttendance()
        {
            int empHrs = 0, dailyEmpWage; 
            const int wagePerHour = 20;

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
            dailyEmpWage = (wagePerHour * empHrs);
            Console.WriteLine("DailyWage is:" + dailyEmpWage);
        }
    }
}
