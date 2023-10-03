using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht4
    {
        public static void Run()
        {
            int chosen_num = -1;

            do
            {
                Console.WriteLine("Voer AUB een geldig nummer in");
                chosen_num = Convert.ToInt32(Console.ReadLine());
            }
            while (chosen_num <= 0 || chosen_num > 10);

            Console.WriteLine($"Nummer {chosen_num} is bevestigd!");
        }
    }
}
