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
            Attendance amazon = new Attendance("Amazon", 40, 30, 150);
            amazon.CheckAttendance();
            Console.WriteLine(amazon.ToString());

            Attendance reliance = new Attendance("Reliance", 40, 20, 100);
            reliance.CheckAttendance();
            Console.WriteLine(reliance.ToString());
            Console.ReadLine();
        }
    }
}
