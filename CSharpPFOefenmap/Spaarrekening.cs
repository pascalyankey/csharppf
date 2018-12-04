using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Spaarrekening : Rekening
    {
        public Spaarrekening(string rekeningnummer, decimal bedrag, DateTime creatiedatum, Klant klant, float intrest) : base(rekeningnummer, bedrag, creatiedatum, klant)
        {
            Intrest = intrest;
        }

        private static float intrestValue;
        public static float Intrest
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value >= 0)
                {
                    intrestValue = value;
                }
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Intrest: {0}", Intrest);
        }

    }
}
