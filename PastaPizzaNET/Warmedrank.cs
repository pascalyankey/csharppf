using System;

namespace PastaPizzaNET
{
    public class Warmedrank : Drank
    {
        public Warmedrank(string naam, float prijs):base(naam, prijs)
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
