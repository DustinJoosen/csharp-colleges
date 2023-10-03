using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht5
    {
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                string apart_bericht = "";

                apart_bericht += (i % 3 == 0) ? "Fizz" : "";
                apart_bericht += (i % 5 == 0) ? "Buzz" : "";

                Console.WriteLine((string.IsNullOrEmpty(apart_bericht) ? i : apart_bericht));

            }
        }
    }
}
