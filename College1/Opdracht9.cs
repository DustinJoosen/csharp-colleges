using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht9
    {
        public static void Run()
        {
            int getal = 45;

            string beoordeling = (getal >= 0 && getal <= 49)
                ? "Slecht"
                : (getal <= 59)
                    ? "Matig"
                    : (getal <= 74)
                        ? "Voldoende"
                        : (getal <= 89)
                            ? "Goed"
                            : (getal <= 100)
                                ? "Uitstekend"
                                : "NaN not a valid number";

            Console.WriteLine(beoordeling);

        }
    }
}
