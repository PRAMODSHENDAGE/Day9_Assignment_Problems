using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment_Problems
{
    internal class UC1_EmployeeAttendance
    {
        public static void EmployeeAttendance()
        {
            Console.WriteLine("\nUC1");
            Random obj = new Random();
            int num = obj.Next(0, 2);
            if (num == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
