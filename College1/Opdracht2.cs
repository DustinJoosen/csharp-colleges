using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht2
    {
        public static void Run()
        {
            double getal = 6.4;
            string bericht = string.Empty;

            if (getal < 1.0 || getal > 10.0)
            {
                bericht = "NaN geen geldig cijfer";
            } 
            else if (getal < 4.0)
            {
                bericht = "Slecht";
            } 
            else if (getal < 5.5)
            {
                bericht = "Matig";
            } 
            else if (getal < 7.0)
            {
                bericht = "Voldoende";
            } 
            else if (getal < 8.5)
            {
                bericht = "Goed";
            } 
            else
            {
                bericht = "Uitstekend";
            }

            Console.WriteLine(bericht);
        }
    }
}
