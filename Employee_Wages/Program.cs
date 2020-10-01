using System;
class Program
{

    public const int IS_Part_Time = 1;
    public const int IS_Full_Time = 2;


    static void Main(string[] args)
    {
        CalculateMonthlyWage("Walmart", 20, 25, 140);
        CalculateMonthlyWage("Dtech", 42, 20, 100);

    }
    public static void CalculateMonthlyWage(string companyName, int wagePerHour, int workingDays, int maxHoursPerMonth)
    {
       Console.WriteLine("Welcome Employee");

        var wageHour = 0;
        var monthlyWage = 0;
        var totalHours = 0;
        var totalWorkingDays = 0;
        while (totalHours <= maxHoursPerMonth && totalWorkingDays <= workingDays)
        {
            totalWorkingDays++;
            var empCheck = new Random().Next(0, 3);
            switch (empCheck)
            {
                case IS_Part_Time:
                    wageHour = 4;
                    break;
                case IS_Full_Time:
                    wageHour = 8;
                    break;
                default:
                    wageHour = 0;
                    break;
            }
            totalHours += wageHour;
        }
        monthlyWage = totalHours * wagePerHour;
        Console.WriteLine("Employee's monthly Wage for {0} is : {1}", companyName, monthlyWage);
    }
}
