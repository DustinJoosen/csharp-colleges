using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht6
    {
        public static void Run()
        {
            List<string> namen = new()
            {
                "Anna",
                "Bob",
                "Charlie",
                "Dae",
                "Eva",
                "Frank",
                "Grace",
                "Harry",
                "Ivy",
                "Jack"
            };

            foreach (var name in namen)
            {
                if (name.Count() >= 5)
                {
                    continue;
                }

                Console.WriteLine(name);
            }
        }
    }
}
