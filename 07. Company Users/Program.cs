using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();
            AddCompany(company);
            Print(company);
        }



        static void AddCompany(Dictionary<string, List<string>> company)
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] infoCompany = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                //{companyName} -> {employeeId}"
                string companyName = infoCompany[0];
                string employeeId = infoCompany[1];
                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                }
                if (company[companyName].Contains(employeeId))
                {
                    input = Console.ReadLine();
                    continue;
                }
                company[companyName].Add(employeeId);

                input = Console.ReadLine();
            }
        }

        static void Print(Dictionary<string, List<string>> company)
        {
            foreach (var nmc in company)
            {
                Console.WriteLine($"{nmc.Key}");
                foreach (var id in nmc.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
