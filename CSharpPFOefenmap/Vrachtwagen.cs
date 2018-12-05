using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Vrachtwagen : Voertuig
    {
        public Vrachtwagen(string polishouder, string nummerplaat, decimal kostprijs, int pk, float gemVer, float maximumlading = 10000):base(polishouder, nummerplaat, kostprijs, pk, gemVer)
        {
            MaximumLading = maximumlading;
        }

        private float maximumlading;
        public float MaximumLading
        {
            get
            {
                return maximumlading;
            }
            set
            {
                if (value >= 0)
                {
                    maximumlading = value;
                }
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Maximum lading: {0}", MaximumLading);
        }

        public override double GetKyotoScore()
        {
            return GemiddeldVerbruik * Pk / MaximumLading;
        }

        public override double GeefVervuiling()
        {
            return GetKyotoScore() * 20;
        }
    }
}
