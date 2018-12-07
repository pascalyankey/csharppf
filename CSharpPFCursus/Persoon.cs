using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    public class Persoon
    {
        public string Naam { get; set; }
        public int AantalKinderen { get; set; }

        public Persoon()
        {

        }

        public Persoon(string naam)
        {
            Naam = naam;
        }

        public Persoon(string naam, int aantalKinderen) : this(naam)
        {
            AantalKinderen = aantalKinderen;
        }
    }
}
