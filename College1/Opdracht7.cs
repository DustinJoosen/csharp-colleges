using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht7
    {
        public static void Run()
        {
            int i = 0;
            int primes_found = 0;

            while (true)
            {
                if (IsPrime(i++))
                {
                    Console.WriteLine(i-1);

                    if (++primes_found >= 10)
                    {
                        break;
                    }
                }
            }
        }

        private static bool IsPrime(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }

            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
