using System;
using System.Collections.Generic;

namespace PastaPizzaNET
{
    public class Pizza : Gerecht
    {
        public Pizza(string naam, float prijs, List<string> onderdelen) : base(naam, prijs)
        {
            Onderdelen = onderdelen;
        }
        public List<string> Onderdelen { get; set; }

        public override float BerekenBedrag()
        {
            throw new NotImplementedException();
        }
    }
}
