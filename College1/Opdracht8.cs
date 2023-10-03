using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht8
    {
        public static void Run()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
