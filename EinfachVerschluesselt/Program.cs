using System;

namespace EinfachVerschluesselt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text (unsicher) verschlüsseln mit ROT-13!");
            Console.WriteLine();

            // Text vom Benutzer eingeben lassen
            string zuverschlüsselnderText;
            Console.WriteLine("Bitte gib den zu verschlüselnden Text ein:");
            zuverschlüsselnderText = Console.ReadLine();

            // Text verschlüsseln
            string verschluesselterText = VerschluesselnMitRot13(zuverschlüsselnderText);

            // verschlüsselten Text ausgeben
            Console.WriteLine();
            Console.WriteLine($"Der verschlüsselte Text lautet: {verschluesselterText}");
            Console.WriteLine();

            // Warten bis der Benutzer das Programm beendet
            Console.WriteLine("Zum Beenden bitte 'Enter' drücken");
            Console.ReadLine();
        }

        private static string VerschluesselnMitRot13(string unverschluesselterText)
        {
            // Alles in Großbuchstaben konvertieren
            // Umlaute entfernen (normalisieren)
            // Zahlen und Sonderzeichen ignorieren
            // Alle Buchstaben um 13 Stellen verschieben

            // Umwandlung in Großbuchstaben
            string textInGroß = unverschluesselterText.ToUpper();
            string verschluesselterText = "";
            string[] umlaute = { "Ä", "Ö", "Ü" };
            string[] norm = { "AE", "OE", "UE" };

            foreach (char c in textInGroß)              // Für jeden Buchstaben
            {
                foreach (string s in umlaute)           // Jeder Buchstabe wird auf Umlaute geprüft
                {
                    if (textInGroß.Contains(s))         // Wenn der Buchstabe ein Umlaut ist ...
                    {
                        int index = Array.IndexOf(umlaute, s); // Der 1., 2. oder 3. Index (bzw. Umlaut)
                        textInGroß = textInGroß.Replace(umlaute[index], norm[index]); // Ersetze den Umlaut durch die Norm
                    }
                }
            }


            verschluesselterText = textInGroß;

            return verschluesselterText;
        }
    }
}
