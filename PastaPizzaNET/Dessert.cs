using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNET
{
    public enum Desserten
    {
        Tiramisu=3,
        Ijs=3,
        Cake=2
    }
    public class Dessert : IBedrag
    {
        private Desserten naamValue;
        public Desserten Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (Enum.IsDefined(typeof(Desserten), value))
                    naamValue = value;
                else
                    throw new Exception("Opgegeven dessert is niet in de lijst!");
            }
        }
        public float Prijs { get; set; }

        public float BerekenBedrag()
        {
            throw new NotImplementedException();
        }
    }
}
