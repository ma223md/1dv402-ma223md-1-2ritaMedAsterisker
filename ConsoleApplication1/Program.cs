using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 25; row++) // Skriver ut 25 rader
            {
                if ((row % 2) != 0) // Varannan rad skjutes in med ett mellanslag
                {
                    Console.Write(" ");
                }
                for (int col = 0; col <= 38; col++) // Skriver ut 39 kolumner i tre olika färger
                {
                int rest = row % 3; // deklarera variabel för färgindelning
                switch (rest)
                    {
                        case 0: // färgar var tredje rad grön
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                        case 1: // färgar var tredje rad gul
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                        case 2: // färgar var tredje rad magneta
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    }
                Console.Write("* ", row * col); // Skriver ut kolumner
                }

                Console.WriteLine(""); // Byter rad efter kolumner skrivits ut
                Console.ResetColor(); // Återgår till originalfärg
            }

        }
    }
}
