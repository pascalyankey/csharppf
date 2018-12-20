namespace PastaPizzaNET
{
    public class Klant
    {
        public Klant(int id, string naam = "Onbekende klant")
        {
            KlantID = id;
            Naam = naam;
        }

        public int KlantID { get; set; }
        public string Naam { get; set; }
        public override string ToString()
        {
            return Naam;
        }
    }
}
