using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    public class Bediende : Werknemer
    {
        public Bediende(string naam, DateTime indienst, Geslacht geslacht, decimal wedde):base(naam, indienst, geslacht)
        {
            Wedde = wedde;
        }

        public override decimal Bedrag
        {
            get
            {
                return Wedde * 12m;
            }
        }

        private decimal weddeValue;
        public decimal Wedde
        {
            get
            {
                return weddeValue;
            }
            set
            {
                if (value >= 0m)
                {
                    weddeValue = value;
                }
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Wedde: {0}", Wedde);
        }

        public override string ToString()
        {
            return base.ToString() + ' ' + Wedde + " euro/maand";
        }

        public override decimal Premie
        {
            get
            {
                return Wedde * 2;
            }
        }
    }
}
