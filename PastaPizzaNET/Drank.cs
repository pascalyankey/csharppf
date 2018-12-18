using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNET
{
    public enum Dranken
    {
        Water=200,
        Limonade=200,
        Cocacola=200,
        Koffie=250,
        Thee=250
    }
    public abstract class Drank : IBedrag
    {
        private Dranken naamValue;
        public Dranken Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (Enum.IsDefined(typeof(Dranken), value))
                    naamValue = value;
                else
                    throw new Exception("Opgegeven drank is niet in de lijst!");
            }
        }
        public float Prijs { get; set; }

        public float BerekenBedrag()
        {
            throw new NotImplementedException();
        }
    }
}
