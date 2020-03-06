using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            while (countStudents!=0)
            {
                string[] input = Console.ReadLine().Split().Select(s => s.Trim()).ToArray();
                Student student = new Student(input[0],input[1],double.Parse(input[2]));
                students.Add(student);
                countStudents--;
            }
            foreach (var student in students.OrderByDescending(s=> s.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public Student(string firstName,string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}
