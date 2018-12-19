namespace PastaPizzaNET
{
    public abstract partial class Gerecht : IBedrag
    {
        public Gerecht(string naam, float prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }
        public string Naam { get; set; }
        public float Prijs { get; set; }

        public abstract float BerekenBedrag();
    }
}
