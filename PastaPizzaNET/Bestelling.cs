using System;

namespace PastaPizzaNET
{
    public class Bestelling : IBedrag
    {
        public Bestelling(int bestelnr, Klant klant, Gerecht gerecht, Drank drank, Dessert dessert, int aantal = 1)
        {
            BestelNr = bestelnr;
            Klant = klant;
            Gerecht = gerecht;
            Drank = drank;
            Dessert = dessert;
            Aantal = aantal;
        }

        public Bestelling(int bestelnr, Klant klant, Gerecht gerecht, Drank drank, int aantal = 1)
        {
            BestelNr = bestelnr;
            Klant = klant;
            Gerecht = gerecht;
            Drank = drank;
            Aantal = aantal;
        }

        public Bestelling(int bestelnr, Klant klant, Gerecht gerecht, Dessert dessert, int aantal = 1)
        {
            BestelNr = bestelnr;
            Klant = klant;
            Gerecht = gerecht;
            Dessert = dessert;
            Aantal = aantal;
        }

        public Bestelling(int bestelnr, Klant klant, Gerecht gerecht, int aantal = 1)
        {
            BestelNr = bestelnr;
            Klant = klant;
            Gerecht = gerecht;
            Aantal = aantal;
        }

        public Bestelling(int bestelnr, Klant klant, Drank drank, int aantal = 1)
        {
            BestelNr = bestelnr;
            Klant = klant;
            Drank = drank;
            Aantal = aantal;
        }

        public Bestelling(int bestelnr, Klant klant, Dessert dessert, int aantal = 1)
        {
            BestelNr = bestelnr;
            Klant = klant;
            Dessert = dessert;
            Aantal = aantal;
        }

        public int BestelNr { get; set; }
        public int Aantal { get; set; }
        private const float Korting = 0.1f;
        public Klant Klant { get; set; }
        public Gerecht Gerecht { get; set; }
        public Drank Drank { get; set; }
        public Dessert Dessert { get; set; }

        public float BerekenBedrag()
        {
            var totaalPrijs = 0f;

            if (Gerecht != null && Gerecht.Grootte != null)
            {
                totaalPrijs += (int)Enum.Parse(typeof(BesteldGerecht.Grootte), Gerecht.Grootte);
            }

            if (Gerecht != null && Gerecht.Extra != null)
            {
                foreach (var item in Gerecht.Extra)
                {
                    totaalPrijs += (int)Enum.Parse(typeof(BesteldGerecht.Extra), item);
                }
            }

            if (Gerecht != null)
                totaalPrijs += Gerecht.Prijs;
            if (Drank != null)
                totaalPrijs += Drank.Prijs;
            if (Dessert != null)
                totaalPrijs += Dessert.Prijs;
            if (Gerecht != null && Drank != null && Dessert != null)
                return totaalPrijs * Aantal - (totaalPrijs * Aantal * Korting);
            else
                return totaalPrijs * Aantal;
        }

        public override string ToString()
        {
            return "Bedrag van deze bestelling: " + BerekenBedrag() + " euro";
        }

        public void ToonDetails()
        {
            Console.WriteLine($"Klant: {Klant.ToString()}");
            if (Gerecht != null)
                Console.WriteLine($"Gerecht: {Gerecht.ToString()}");
            if (Drank != null)
                Console.WriteLine($"Drank: {Drank.ToString()}");
            if (Dessert != null)
                Console.WriteLine($"Dessert: {Dessert.ToString()}");
            Console.WriteLine($"Aantal: {Aantal}");
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public string objectToString(Bestelling bestelling)
        {
            return "";
        }
    }
}
