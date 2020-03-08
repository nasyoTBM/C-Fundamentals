using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CompanyRoster
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            List<Department> departments = new List<Department>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').Select(s => s.Trim()).ToArray();
                Employee employee = new Employee(input[0],decimal.Parse(input[1]));
                employees.Add(employee);
                if (!departments.Any(x=>x.Name==input[2]))
                {
                    departments.Add(new Department(input[2]));
                }
                departments.Find(d => d.Name == input[2]).AddNewEmployee(input[0], decimal.Parse(input[1]));



            }
            Department bestDepartment = departments.OrderByDescending(x => x.TotalSalaries / x.Employees.Count()).First();
            Console.WriteLine($"Highest Average Salary: {bestDepartment.Name}");

            foreach (var employee in bestDepartment.Employees.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
            
           
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
       
        public Employee(string name,decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
            
        }
        
    }
    class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public decimal TotalSalaries { get; set; }

        public Department(string name)
        {
            this.Name = name;
        }
        public void AddNewEmployee(string empName, decimal empSalary)
        {
            this.TotalSalaries += empSalary;

            this.Employees.Add(new Employee(empName, empSalary));
        }
    }
}
