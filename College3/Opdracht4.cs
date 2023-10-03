using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College3
{
    public class Opdracht4
    {
        public static void Run()
        {
            List<Student> students = new()
            {
                new Student { Name = "Dustin", Age = 20, Grade = 8 },
                new Student { Name = "Laurens", Age = 21, Grade = 3 },
                new Student { Name = "Lars", Age = 19, Grade = 7 },
                new Student { Name = "Koen", Age = 22, Grade = 5 },
            };

            // A)
            var students_older_then_20 = from student in students
                                         where student.Age > 20
                                         select student;

            Console.WriteLine(string.Join(", ", students_older_then_20));

            // B)
            var grades = (from student in students_older_then_20
                                select student.Grade);

            Console.WriteLine(grades.Average());

            // C)
            var failed_students = from student in students where student.Grade < 5.5 select student;
            var failed_students_alphabetized = failed_students.OrderBy(s => s.Name);
            Console.WriteLine(string.Join(", ", failed_students_alphabetized));
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Age} years, grade: {Grade})";
        }
    }
}
