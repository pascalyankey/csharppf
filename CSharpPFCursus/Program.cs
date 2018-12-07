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
        static void UitgebreideWerknemersLijst(Werknemer[] werknemers)
        {
            foreach (Werknemer eenWerknemer in werknemers)
                eenWerknemer.Afbeelden();
        }
        static void Main(string[] args)
        {
            Werknemer[] werknemers = new Werknemer[2];
            werknemers[0] = new Arbeider("Asterix", new DateTime(2018, 1, 1), Geslacht.Man, 24.79m, 3);
            werknemers[1] = new Bediende("Obelix", new DateTime(2018, 1, 1), Geslacht.Man, 1500m);
            Action<Werknemer[]> toonWerknemers = UitgebreideWerknemersLijst;
            toonWerknemers(werknemers);
        }
    }
}