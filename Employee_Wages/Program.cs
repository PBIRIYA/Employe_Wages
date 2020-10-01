using System;

namespace Employee_Wages
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpWages(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + " Emp Hrs:", empHrs);
            }
            int totalEmpwage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage For Company :" + company + "is:" + totalEmpwage);
            return totalEmpwage;
        }
            static void Main(string[] args)
            Program computeEmpWage= new Program ("Dmart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}


