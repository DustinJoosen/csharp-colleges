using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht1
    {
        public static void Run()
        {
            int getal = 8;
            string beoordeling = string.Empty;

            switch (getal)
            {
                case 1:
                case 2:
                case 3:
                    beoordeling = "Slecht";
                    break;
                case 4:
                case 5:
                    beoordeling = "Matig";
                    break;
                case 6:
                    beoordeling = "Voldoende";
                    break;
                case 7:
                case 8:
                    beoordeling = "Goed";
                    break;
                case 9:
                case 10:
                    beoordeling = "Uitstekend";
                    break;
                default:
                    beoordeling = "NaN geen getal";
                    break;
            }

            Console.WriteLine(beoordeling);
        }
    }
}
