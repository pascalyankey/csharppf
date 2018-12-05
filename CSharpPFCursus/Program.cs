using System;
using Firma.Personeel;
using Firma.Materiaal;

namespace CSharpPFCursus
{
    class Program
    {
        delegate void WerknemersLijst(Werknemer[] werknemers);
        static void Main(string[] args)
        {
            /*Werknemer[] wij = new Werknemer[3];
            wij[0] = new Arbeider("Asterix", new DateTime(2018, 1, 1), Geslacht.Man, 24.79m, 3);
            wij[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
            wij[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);

            WerknemersLijst rapport;

            rapport = delegate (Werknemer[] werknemers)
            {
                decimal totaal = 0m;
                foreach (Werknemer werknemer in werknemers)
                    totaal += werknemer.Bedrag;
                Console.WriteLine($"Totale kost is {totaal}");
            };
            rapport(wij);*/

            Fotokopiemachine machine = new Fotokopiemachine("123", 0, 2.0m);
            Bediende eenBediende = new Bediende("Asterix", DateTime.Today, Geslacht.Man, 2400.79m);

            machine.OnderhoudNodig += delegate (Fotokopiemachine apparaat)
            {
                Console.WriteLine($"Onderhoud is aangevraagd voor machine" + $" {apparaat.SerieNr}.");
            };

            machine.OnderhoudNodig += eenBediende.DoeOnderhoud;
            machine.Fotokopieer(49);
        }
    }
}
