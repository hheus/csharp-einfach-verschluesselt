﻿using System;

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
            return "Verschluesselung noch nicht implementiert";
        }
    }
}
