﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");
            Dictionary<string, int> wageForCompanies = new Dictionary<string, int>();
            bool cont = true;
            int option;
            while (cont)
            {
                Console.WriteLine("Enter\n" +
                    "1 : Enter Company Details\n" +
                    "2 : Retrieve Wage Details\n" +
                    "0 : Exit");
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        cont = false;
                        break;
                    case 1:
                        Company oneCompany = new Company();
                        oneCompany.EnterCompanyDetails();
                        EmpWageBuilder empWage = new EmpWageBuilder(oneCompany);
                        wageForCompanies.Add(oneCompany.Name, empWage.TotalMonthlyWage);
                        break;
                    case 2:
                        foreach (var company in wageForCompanies)
                        {
                            Console.WriteLine("Company : " + company.Key + " , " + "Monthly Wage :" + company.Value);
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Wrong Option choosed");
                        break;
                }
            }
            return;
        }
        public Company EnterCompanyDetails()
        {
            Company company = new Company();
            Console.Write("Company Name : ");
            company.Name = Console.ReadLine();
            Console.Write("Full Day Work Hour : ");
            company.FullDayWorkHour = Int32.Parse(Console.ReadLine());
            Console.Write("Wage per Work Hour : ");
            company.WagePerHour = Int32.Parse(Console.ReadLine());
            Console.Write("Monthly Work Day : ");
            company.MonthlyWorkingDay = Int32.Parse(Console.ReadLine());
            Console.Write("Max Monthly Work Hour : ");
            company.MonthlyMaxWorkHour = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            return company;
        }
    }
}