using System;

namespace Employee_Wages
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_NONTH = 10;
        public static int computeEmpWages()
        {
            //Variables
            int empHrs = 0;
            int empWorkingDays = 0;
            int totalEmpHrs = 0;
            int empWage = 0;
            while (totalEmpHrs <= MAX_HRS_IN_NONTH && empWorkingDays < NUM_OF_WORKING_DAYS)
            {
                empWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + empWorkingDays + empHrs);
            }
            int totalEmpwage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : * + totalEmpwage");
            return totalEmpwage;
        }
        static void Main(string[] args)
    }   
}

