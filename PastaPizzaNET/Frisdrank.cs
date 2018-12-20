using System;

namespace PastaPizzaNET
{
    public class Frisdrank : Drank
    {
        public Frisdrank(string naam, float prijs) : base(naam, prijs)
        {

        }

        public override float BerekenBedrag()
        {
            return Prijs;
        }

        public override string ToString()
        {
            return Naam + " <" + BerekenBedrag() + " euro>";
        }
    }
}
