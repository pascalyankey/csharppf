using System;
using Firma.Personeel;
using Firma.Materiaal;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            var personen = new[]
            {
                new { Naam = "Jan", AantalKinderen = 1 },
                new { Naam = "Mieke", AantalKinderen = 2 },
                new { Naam = "Els", AantalKinderen = 1 }
            };

            var toegangsprijzen = new[]
            {
                new {AantalKinderen = 1, Bedrag = 10 },
                new {AantalKinderen = 2, Bedrag = 25 }
            };

            var toegangsPrijzenPerPersoon =
                from persoon in personen
                join toegangsprijs in toegangsprijzen
                on persoon.AantalKinderen equals toegangsprijs.AantalKinderen
                select new { persoon.Naam, toegangsprijs.Bedrag };

            foreach (var persoon in toegangsPrijzenPerPersoon)
                Console.WriteLine($"{persoon.Naam}: {persoon.Bedrag} euro");
        }
    }
}