using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht10
    {

        public static void Run()
        {
            Console.WriteLine("Welkom bij de star-trek quiz\n");

            string answer_1 = string.Empty;
            string answer_2 = string.Empty;
            string answer_3 = string.Empty;

            bool answer_1_correct = false;
            bool answer_2_correct = false;
            bool answer_3_correct = false;

            int points = 0;

            // Q1
            Console.WriteLine("\nQuestion 1: What is the name of the chief engineer on ds9?");
            Console.WriteLine("A) Odo");
            Console.WriteLine("B) O'Brien");
            Console.WriteLine("C) Sisko");
                
            Console.Write(">>>");
            answer_1 = Console.ReadLine();
            answer_1_correct = answer_1.Equals("B");


            // Q2
            Console.WriteLine("\nQuestion 2: What is the name of the chief engineer on voy?");
            Console.WriteLine("A) Torres");
            Console.WriteLine("B) Paris");
            Console.WriteLine("C) Kim");

            Console.Write(">>>");
            answer_2 = Console.ReadLine();
            answer_2_correct = answer_2.Equals("A");


            // Q3
            Console.WriteLine("\nQuestion 3: What is the name of the chief engineer on snw?");
            Console.WriteLine("A) Pike");
            Console.WriteLine("B) Ortegas");
            Console.WriteLine("C) Hemmer");

            Console.Write(">>>");
            answer_3 = Console.ReadLine();
            answer_3_correct = answer_3.Equals("C");


            // Display results.
            points += (answer_1_correct ? 1 : 0);
            points += (answer_2_correct ? 1 : 0);
            points += (answer_3_correct ? 1 : 0);

            Console.WriteLine("\n");
            Console.WriteLine("Question 1: " + (answer_1_correct ? "Correct!" : "Wrong!"));
            Console.WriteLine("Question 2: " + (answer_2_correct ? "Correct!" : "Wrong!"));
            Console.WriteLine("Question 3: " + (answer_3_correct ? "Correct!" : "Wrong!"));


            Console.WriteLine($"\nYou got {points} points!");

        }

    }
}
