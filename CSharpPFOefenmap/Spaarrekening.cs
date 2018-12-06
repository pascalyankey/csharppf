using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Spaarrekening : Rekening
    {
        public class OngeldigIntrestException : Exception
        {
            private float ongeldigIntrestValue;
            public float OngeldigIntrest
            {
                get
                {
                    return ongeldigIntrestValue;
                }
                set
                {
                    ongeldigIntrestValue = value;
                }
            }

            public OngeldigIntrestException(string message, float ongeldigIntrest) : base(message)
            {
                OngeldigIntrest = ongeldigIntrest;
            }
        }

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
                if (value < 0)
                    throw new OngeldigIntrestException("Intrest mag niet negatief zijn!", value);
                intrestValue = value;
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Intrest: {0}", Intrest);
        }

    }
}
