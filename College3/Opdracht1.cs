using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College3
{
    public class Opdracht1
    {
        public static void Run()
        {
            List<int> numbers = new();
            Random rand = new();

            // Define original list.
            for (int i = 0; i < 10; i++)
                numbers.Add(rand.Next(0, 1000));

            // Original.
            Console.WriteLine("Original list:");
            Console.WriteLine(string.Join(", ", numbers));
            
            // Sorted.
            Console.WriteLine("\nSorted list:");
            numbers.Sort();
            Console.WriteLine(string.Join(", ", numbers));

            // Reversed.
            Console.WriteLine("\nReversed list:");
            numbers.Reverse();
            Console.WriteLine(string.Join(", ", numbers));

            // Without even nums.
            Console.WriteLine("\nWithout even nums:");
            numbers.RemoveAll(num => num % 2 == 0);
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
