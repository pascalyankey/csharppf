using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Personenwagen : Voertuig
    {
        public Personenwagen(string polishouder, string nummerplaat, decimal kostprijs, int pk, float gemVer, int aantaldeuren = 4, int aantalpassagiers = 5) : base(polishouder, nummerplaat, kostprijs, pk, gemVer)
        {
            AantalDeuren = aantaldeuren;
            AantalPassagiers = aantalpassagiers;
        }

        private int aantaldeurenValue;
        public int AantalDeuren
        {
            get
            {
                return aantaldeurenValue;
            }
            set
            {
                if (value > 0)
                {
                    aantaldeurenValue = value;
                }
            }
        }

        private int aantalpassagiersValue;
        public int AantalPassagiers
        {
            get
            {
                return aantalpassagiersValue;
            }
            set
            {
                if (value > 0)
                {
                    aantalpassagiersValue = value;
                }
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Aantal deuren: {0}", AantalDeuren);
            Console.WriteLine("Aantal passagiers: {0}", AantalPassagiers);
        }

        public override double GetKyotoScore()
        {
            return GemiddeldVerbruik * Pk / AantalPassagiers;
        }

        public override double GeefVervuiling()
        {
            return GetKyotoScore() * 5;
        }
    }
}
