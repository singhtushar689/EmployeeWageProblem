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
            int present = 1;
            int absent = 2;
            Random random = new Random();
            int checkOption = random.Next(1, 3);
            switch (checkOption)
            {
                case 1:
                    Console.WriteLine("Employee is present");
                    break;
                case 2:
                    Console.WriteLine("Employee is absent");
                    break;
            }

        }
    }
}
