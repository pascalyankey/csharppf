using System;
using System.Collections.Generic;
using System.Text;

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
                totaalPrijs += (int)Enum.Parse(typeof(Gerecht.BesteldGerecht.Grootte), Gerecht.Grootte);
            }

            if (Gerecht != null && Gerecht.Extra != null)
            {
                foreach (var item in Gerecht.Extra)
                {
                    totaalPrijs += (int)Enum.Parse(typeof(Gerecht.BesteldGerecht.Extra), item);
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

        public string ShowGerecht()
        {
            if (Gerecht != null)
            {
                var extraBuilder = new StringBuilder();
                extraBuilder.Append(Gerecht.Naam + "-" + Gerecht.Grootte + "-");
                if (Gerecht.Extra != null)
                    extraBuilder.Append(Gerecht.Extra.Count + "-");
                else
                    extraBuilder.Append(0 + "-");
                if (Gerecht.Extra != null)
                {
                    var teller = 0;
                    foreach (var item in Gerecht.Extra)
                    {
                        teller++;
                        if (teller == Gerecht.Extra.Count)
                            extraBuilder.Append(item);
                        else
                            extraBuilder.Append(item + "-");
                    }
                }
                return extraBuilder.ToString();
            }
            else
                return "";
        }


        public string ShowDrank()
        {
            if (Drank != null)
            {
                if (Drank.GetType() == typeof(Frisdrank))
                    return "F" + "-" + Drank.Naam;
                else
                    return "W" + "-" + Drank.Naam;
            }
            else
                return "";
        }

        public string ShowDessert()
        {
            if (Dessert != null)
                return Dessert.Naam;
            else
                return "";
        }

        public string ObjectToString()
        {
            return Klant.KlantID + "#" + ShowGerecht() + "#" + ShowDrank() + "#" + ShowDessert() + "#" + Aantal;
        }
    }
}
