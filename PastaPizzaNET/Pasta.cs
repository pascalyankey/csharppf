using System;

namespace PastaPizzaNET
{
    public class Pasta : Gerecht
    {
        public Pasta(string naam, float prijs, string omschrijving):base(naam, prijs)
        {
            Omschrijving = omschrijving;
        }
        public string Omschrijving { get; set; }

        public override float BerekenBedrag()
        {
            throw new NotImplementedException();
        }
    }
}
