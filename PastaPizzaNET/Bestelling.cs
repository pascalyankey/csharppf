namespace PastaPizzaNET
{
    public class Bestelling : IBedrag
    {
        public Bestelling(int bestelnr, Klant klant, int aantal = Aantal)
        {
            BestelNr = bestelnr;
            Klant = klant;
            AantalBestelling = aantal;
        }

        public int BestelNr { get; set; }
        private const int Aantal = 1;
        public int AantalBestelling { get; set; }
        private const float Korting = 0.1f;
        public Klant Klant { get; set; }
        public Gerecht Gerecht { get; set; }
        public BesteldGerecht BesteldGerecht { get; set; }
        public Drank Drank { get; set; }
        public Dessert Dessert { get; set; }

        public float BerekenBedrag()
        {
            float totaalPrijs = 0;

            int extraPrijs = 0;
            if (BesteldGerecht.GerechtExtra.Count != 0)
            {
                foreach(var item in BesteldGerecht.GerechtExtra)
                {
                    extraPrijs += (int)item;
                }
            }

            if (Gerecht != null)
                totaalPrijs += Gerecht.Prijs + (int)BesteldGerecht.GerechtGrootte + extraPrijs;
            if (Drank != null)
                totaalPrijs += Drank.Prijs;
            if (Dessert != null)
                totaalPrijs += Dessert.Prijs;
            if (Gerecht != null && Drank != null && Dessert != null)
                return totaalPrijs * Korting * Aantal;
            else
                return totaalPrijs * Aantal;
        }

        public override string ToString()
        {
            return "Bedrag van deze bestelling: " + BerekenBedrag();
        }
    }
}
