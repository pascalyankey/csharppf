using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNET
{
    public class Bestelling : IBedrag
    {
        private const int Aantal = 1;
        private const float Korting = 0.1f;
        public Klant Klant { get; set; }
        public Gerecht Gerecht { get; set; }
        public BesteldGerecht BesteldGerecht { get; set; }
        public Drank Drank { get; set; }
        public Dessert Dessert { get; set;}
        public float BerekenBedrag()
        {
            throw new NotImplementedException();
        }
    }
}
