using System;

namespace PastaPizzaNET
{
    public class Warmedrank : Drank
    {
        public Warmedrank(Dranken naam, float prijs):base(naam, prijs)
        {

        }
        public override float BerekenBedrag()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Naam + " <" + Prijs + " euro>";
        }
    }
}
