using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag_2___Gissa_Talet__Version_1__med_kommentarer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa talet");
            Console.WriteLine("Du ska nu gissa ett tal mellan 1-100, så varsågod");
            Console.WriteLine("Skriv in ett tal");
            string str = Console.ReadLine();          // Läser in vilket tal användaren skriver in
            int nr = Convert.ToInt32(str);            // Typomvandlar string till int 

            if (nr == 50)                              // OM användaren skriver in 50 så händer följande (rätt svar)
            {
                Console.WriteLine("Grattis du gissade rätt!");
                Console.WriteLine("Programmet är slut");
                str = Console.ReadLine();
            }
            if (nr < 46)                               // OM användaren skriver in ett värde som är 46 eller mindre så händer följande
            {
                Console.WriteLine("Ditt tal är för litet, gissa på ett större tal");
                Console.WriteLine("Programmet är slut");
                str = Console.ReadLine();

            }
            else if (nr == 49)                         // ANNARS OM användaren skriver in talet 49 så händer följande 
            {
                Console.WriteLine("Ditt tal är för litet, gissa på ett större tal");
                Console.WriteLine("Du är dock nära och det bränns");
                Console.WriteLine("Programmet är slut");
                str = Console.ReadLine();
            }
            else if (nr == 48)                          // ANNARS OM användaren skriver in talet 48 så händer följande 
            {
                Console.WriteLine("Ditt tal är för litet, gissa på ett större tal");
                Console.WriteLine("Du är dock nära och det bränns");
                Console.WriteLine("Programmet är slut");
                str = Console.ReadLine();
            }
            else if (nr == 47)                          // ANNARS OM användaren skriver in talet 47 så händer följande 
            {
                Console.WriteLine("Ditt tal är för litet, gissa på ett större tal");
                Console.WriteLine("Du är dock nära och det bränns");
                Console.WriteLine("Programmet är slut");
                str = Console.ReadLine();
            }
            if (nr > 100)                               // OM använder skriver ett tal som är över 100 så händer följande
            {
                Console.WriteLine("Du måste skriva in ett tal mellan 1-100!");
                Console.WriteLine("Programmet är slut");
                str = Console.ReadLine();
            }
            else if (nr > 54)                           // ANNARS OM användaren skriver ett tal som är mellan 54-100 så händer följande
            {
                Console.WriteLine("Ditt tal är för stort, gissa på ett mindre tal");
                Console.WriteLine("Programmet är slut");
                str = Console.ReadLine();
            }
            else if (nr == 51)                         // ANNARS OM användaren skriver in talet 51 så händer följande
            {
                Console.WriteLine("Ditt tal är för stort, gissa på ett mindre tal");
                Console.WriteLine("Du är dock nära och det bränns");
                Console.WriteLine("Programmet är slut");
                str = Console.ReadLine();
            }
            else if (nr == 52)                          // ANNARS OM användaren skriver in talet 52 så händer följande
            {
                Console.WriteLine("Ditt tal är för stort, gissa på ett mindre tal");
                Console.WriteLine("Du är dock nära och det bränns");
                Console.WriteLine("Programmet är slut");
                str = Console.ReadLine();
            }
            else if (nr == 53)                          // ANNARS OM användaren skriver in talet 53 så händer följande
            {
                Console.WriteLine("Ditt tal är för stort, gissa på ett mindre tal");
                Console.WriteLine("Du är dock nära och det bränns");
                Console.WriteLine("Programmet är slut");
                str = Console.ReadLine();
            }
        }
    }
}
