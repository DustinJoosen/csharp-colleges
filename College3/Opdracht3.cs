using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College3
{
    public class Opdracht3
    {
        public static void Run()
        {
            List<int> numbers = new();
            Random rand = new();

            // Define original list.
            for (int i = 0; i < 10; i++)
                numbers.Add(rand.Next(0, 1000));

            // A) Get even nums
            var even_nums = from num in numbers where num % 2 == 0 select num;
            Console.WriteLine(string.Join(", ", even_nums));

            // B) Get average
            var avg = numbers.Average();
            Console.WriteLine($"Average: {avg}");

            // C) Words starting with an A
            List<string> names = new()
            {
                "Anna",
                "Beth",
                "Amalia",
                "Cody",
                "Skye",
                "Dustin"
            };

            var names_with_a = from name in names where name.StartsWith("A") select name;
            Console.WriteLine(string.Join(", ", names_with_a));

        }
    }
}
