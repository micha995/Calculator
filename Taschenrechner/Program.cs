using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main()
        {
            // Begrüßung im Terminal
            Console.WriteLine("Willkommen zum Taschenrechner!");

            // Benutzer nach der ersten Zahl fragen
            Console.Write("Gib die erste Zahl ein: ");

            // Eingabe einlesen (als Text)
            string eingabe = Console.ReadLine()!;

            // Text in eine Zahl (double) umwandeln (z.B. x.0)
            double zahl1 = Convert.ToDouble(eingabe);

            // Benutzer nach zweiter Zahl fragen
            Console.Write("Gib die zweite Zahl ein: ");
            string eingabe2 = Console.ReadLine()!;
            double zahl2 = Convert.ToDouble(eingabe2);

            // Benutzer nach dem operator fragen
            Console.WriteLine("Wähle einen Operator: ");
            string operatorZeichen = Console.ReadLine()!;

            // Ergebnis berechnen
            double ergebnis = 0;
                                               
            if (operatorZeichen == "+")
            {
                ergebnis = zahl1 + zahl2;
            }
            else if (operatorZeichen == "-")
            {
                ergebnis = zahl1 - zahl2;
            }
            else if (operatorZeichen == "*")
            {
                ergebnis = zahl1 * zahl2;
            }

            //Division eingefügt
            else if (operatorZeichen == "/")
            {
                if (zahl2 != 0)
                {
                    ergebnis = (zahl1 / zahl2);
                }
                else
                {
                    Console.WriteLine("Fehler! Division durch 0 ist nicht erlaubt!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Ungültiger Operator!");
                return;
            }

            // Ergebnis anzeigen
            Console.WriteLine("Ergebnis: " + ergebnis);
        }
    }
}
