using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Tweet
    {
        public string Naam { get; set; }
        public string Bericht { get; set; }
        public DateTime Tijdstip { get; set; }
        public override string ToString()
        {
            return this.Naam + ": " + this.Bericht + " - " + this.Tijdstip;
        }
    }
}
