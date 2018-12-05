using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Kasbon : ISpaarmiddel
    {
        public Kasbon(DateTime aankoopdatum, decimal bedrag, DateTime looptijd, float intrest, Klant klant)
        {
            AankoopDatum = aankoopdatum;
            Bedrag = bedrag;
            Looptijd = looptijd;
            Intrest = intrest;
            Klant = klant;
        }

        private DateTime aankoopdatumValue;
        public DateTime AankoopDatum
        {
            get
            {
                return aankoopdatumValue;
            }
            set
            {
                if (value.Year > 1900)
                {
                    aankoopdatumValue = value;
                }
            }
        }

        private decimal bedragValue;
        public decimal Bedrag
        {
            get
            {
                return bedragValue;
            }
            set
            {
                if (value > 0)
                {
                    bedragValue = value;
                }
            }
        }

        private DateTime looptijdValue;
        public DateTime Looptijd
        {
            get
            {
                return looptijdValue;
            }
            set
            {
                looptijdValue = value;
            }
        }

        private float intrestValue;
        public float Intrest
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value > 0)
                {
                    intrestValue = value;
                }
            }
        }

        private Klant klantValue;
        public Klant Klant
        {
            get
            {
                return klantValue;
            }
            set
            {
                klantValue = value;
            }
        }

        public void Afbeelden()
        {
            Console.WriteLine("Aankoopdatum: {0}", AankoopDatum);
            Console.WriteLine("Bedrag: {0}", Bedrag);
            Console.WriteLine("Looptijd: {0}", Looptijd);
            Console.WriteLine("Intrest: {0}", Intrest);
            Klant.Afbeelden();
        }
    }
}
