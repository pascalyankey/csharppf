using System;

namespace PastaPizzaNET
{
    public class Frisdrank : Drank
    {
        public Frisdrank(Dranken naam, float prijs) : base(naam, prijs)
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
