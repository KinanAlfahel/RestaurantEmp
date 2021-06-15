using System;
using System.Collections.Generic;

namespace RestaurantEmp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            decimal salary;

            Dictionary<string, decimal> Employees = new Dictionary<string, decimal>();
            Console.WriteLine("Do you want to regiter new employee? [y/n]");

            while (Console.ReadLine().ToLower() == "y")
            {
                Console.WriteLine("Please enter employee name!");
                name = Console.ReadLine();

                Console.WriteLine("Please enter employee Salary!");
                salary = Convert.ToDecimal(Console.ReadLine());

                Employees.Add(name, salary);
                Console.WriteLine("Do you want to regiter new employee? [y/n]");
            }

            foreach (var item in Employees)
            {
                Console.WriteLine(item.Key + " | " + item.Value);
            }
        }
    }
}
