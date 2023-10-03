using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College3
{
    public class Opdracht2
    {
        public static void Run()
        {
            Dictionary<int, string> students = new();

            students.Add(1184503, "Dustin");
            students.Add(1184504, "Pustin");
            students.Add(1184505, "Justin");
            students.Add(1184506, "Kustin");
            students.Add(1192844, "Laurens");
            Console.WriteLine(string.Join(", ", students));

            // Get best student.
            var best_student = students.First(student => student.Value == "Dustin");
            Console.WriteLine(best_student.Key);

            // Remove worst student
            students.Remove(students.First(student => student.Value == "Laurens").Key);
            Console.WriteLine(string.Join(", ", students));
        }
    }
}
