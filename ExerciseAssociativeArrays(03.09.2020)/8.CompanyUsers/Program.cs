using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> golaka = new Dictionary<string, List<double>>();
            Dictionary<string, double> output = new Dictionary<string, double>();
            
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!golaka.ContainsKey(name))
                {
                    golaka.Add(name, new List<double>());
                    golaka[name].Add(grade);
                }
                else
                {
                    golaka[name].Add(grade);
                }
            }
            foreach (var item in golaka)
            {
                double midGrade = 0;
                foreach (var items in item.Value)
                {
                    midGrade += items;
                }
                midGrade /= item.Value.Count;
                if (midGrade>=4.50)
                {
                    output.Add(item.Key, midGrade);
                }
            }
            foreach (var item in output.OrderByDescending(s=>s.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
