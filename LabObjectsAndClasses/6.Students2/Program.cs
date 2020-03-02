using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Students2
{
    public class Student
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.Name == firstName && student.LastName == lastName)
                {
                    return true;
                }

            }
            return false;
        }
        public static Student GetStudent(List<Student> students, string name, string lastName)
        {
            Student existingStudent = null;
            foreach (var student in students)
            {
                if (student.Name == name && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }


    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "end")
            {
                List<string> inputStudents = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string name = inputStudents[0];
                string lastName = inputStudents[1];
                int age = int.Parse(inputStudents[2]);
                string homeTown = inputStudents[3];


                if (Student.IsStudentExisting(students, name, lastName))
                {
                    Student student = Student.GetStudent(students, name, lastName);
                    student.Name = name;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                }
                else
                {
                    Student student = new Student();
                    student.Name = name;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                    students.Add(student);


                }



                input = Console.ReadLine();

            }
            string city = Console.ReadLine();
            List<Student> filteredStudents = students.Where(s => s.HomeTown == city).ToList();
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.Name} {student.LastName} is {student.Age} years old.");
            }

        }

    }
}
