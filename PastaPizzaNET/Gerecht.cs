using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNET
{
    public abstract class Gerecht : IBedrag
    {
        public string Naam { get; set; }
        public float Prijs { get; set; }

        public float BerekenBedrag()
        {
            throw new NotImplementedException();
        }
    }
}
