using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNET
{
    public class Klant
    {
        public Klant(int id = 0, string naam = "Onbekende klant")
        {
            KlantID = id;
            Naam = naam;
        }
        public int KlantID { get; set; }
        public string Naam { get; set; }
    }
}
