using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht3
    {
        public static void Run()
        {
            int minVal = 1;
            int maxVal = 100;

            int correct_num = Random.Shared.Next(minVal, maxVal + 1);
            int guessed_num = -1;

            do
            {
                Console.Write("Guess a number: ");
                guessed_num = Convert.ToInt32(Console.ReadLine());

                if (guessed_num > correct_num)
                {
                    Console.WriteLine("Too high");
                } 
                else if (guessed_num < correct_num)
                {
                    Console.WriteLine("Too low");
                }
            }
            while (guessed_num != correct_num);
            
            Console.WriteLine("Correct!");
        }
    }
}
