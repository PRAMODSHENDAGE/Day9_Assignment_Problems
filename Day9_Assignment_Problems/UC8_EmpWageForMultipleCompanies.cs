using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment_Problems
{
    internal class UC8_EmpWageForMultipleCompanies
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static int ComputeEmpwage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {
            Console.WriteLine("\nUC8");

            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= maxHourPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);

                switch (num)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs; // totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs " + empHrs);

            }
            int totalempwage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company : " + company + " is: " + totalempwage);
            return totalempwage;
        }
        public static void EmpWage()
        {
            ComputeEmpwage("Dmart", 20, 2, 10);
            ComputeEmpwage("Reliance", 10, 4, 20);
        }
    }
}
