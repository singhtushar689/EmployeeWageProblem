using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Attendance attendance = new Attendance();
            attendance.CheckAttendance("Amazon",40,30,150);
            attendance.CheckAttendance("Reliance", 40, 20, 100);
            Console.ReadLine();
        }
    }
}
