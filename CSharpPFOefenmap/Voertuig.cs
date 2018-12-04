using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public abstract class Voertuig
    {
        private string Polishouder;
        private string Nummerplaat;

        public Voertuig(string polishouder = "onbepaald", string nummerplaat = "onbepaald", decimal kostprijs = 0.0m, int pk = 0, float gemVer = 0)
        {
            this.Polishouder = polishouder;
            this.Nummerplaat = nummerplaat;
            this.Kostprijs = kostprijs;
            this.Pk = pk;
            this.GemiddeldVerbruik = gemVer;
        }

        private decimal kostprijsValue;
        public decimal Kostprijs
        {
            get
            {
                return kostprijsValue;
            }
            set
            {
                if (value >= 0)
                {
                    kostprijsValue = value;
                }
            }
        }

        private int pkvalue;
        public int Pk
        {
            get
            {
                return pkvalue;
            }
            set
            {
                if (value >= 0)
                {
                    pkvalue = value;
                }
            }
        }

        private float gemVerValue;
        public float GemiddeldVerbruik
        {
            get
            {
                return gemVerValue;
            }
            set
            {
                if (value >= 0)
                {
                    gemVerValue = value;
                }
            }
        }

        public virtual void Afbeelden()
        {
            Console.WriteLine("Polishouder: {0}", Polishouder);
            Console.WriteLine("Nummerplaat: {0}", Nummerplaat);
            Console.WriteLine("Kostprijs: {0}", Kostprijs);
            Console.WriteLine("Pk: {0}", Pk);
            Console.WriteLine("Gemiddeld verbruik: {0}", GemiddeldVerbruik);
        }

        public abstract double GetKyotoScore();
    }
}
