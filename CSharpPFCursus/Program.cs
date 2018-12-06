using System;
using Firma.Personeel;
using Firma.Materiaal;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CSharpPFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> lijst = new List<Object>()
            {
                new Arbeider("Asterix", new DateTime(2018, 1, 1), Geslacht.Man, 24.79m, 3),
                new Bediende("Obelix", new DateTime(2018, 2, 1), Geslacht.Man, 2400.79m),
                new Fotokopiemachine("123", 500, 0.025m),
                null,
                "C# 7.0"
            };
            foreach (var item in lijst)
            {
                ToonGegevens(item);
            }
        }

        private static void ToonGegevens(Object obj)
        {
            if (obj is Werknemer w)
            {
                Console.WriteLine($"Werknemer {w.Naam} kost {w.Bedrag} euro");
            }
            else if (obj is Fotokopiemachine f)
            {
                Console.WriteLine($"Fotokopiemachine {f.SerieNr} kopieerde" + $" {f.AantalGekopieerdeBlz} en kost {f.Bedrag} euro");
            }
            else
            {
                Console.WriteLine("onbekend type");
            }
        }
    }
}
