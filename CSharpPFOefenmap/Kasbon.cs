using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Kasbon : ISpaarmiddel
    {
        public class NegatiefIntrestException : Exception
        {
            private float negatiefIntrestValue;
            public float NegatiefIntrest
            {
                get
                {
                    return negatiefIntrestValue;
                }
                set
                {
                    negatiefIntrestValue = value;
                }
            }

            public NegatiefIntrestException(string message, float negatiefIntrest) : base(message)
            {
                NegatiefIntrest = negatiefIntrest;
            }
        }

        public class NegatieveLooptijdException : Exception
        {
            private int negatieveLooptijdValue;
            public int NegatieveLooptijd
            {
                get
                {
                    return negatieveLooptijdValue;
                }
                set
                {
                    negatieveLooptijdValue = value;
                }
            }

            public NegatieveLooptijdException(string message, int negatieveLooptijd) : base(message)
            {
                NegatieveLooptijd = negatieveLooptijd;
            }
        }

        public class NegatiefBedragException : Exception
        {
            private decimal negatiefBedragValue;
            public decimal NegatiefBedrag
            {
                get
                {
                    return negatiefBedragValue;
                }
                set
                {
                    negatiefBedragValue = value;
                }
            }

            public NegatiefBedragException(string message, decimal negatiefBedrag) : base(message)
            {
                NegatiefBedrag = negatiefBedrag;
            }
        }

        public class OngeldigeAankoopdatumException : Exception
        {
            private DateTime ongeldigeAankoopdatumValue;
            public DateTime OngeldigeAankoopdatum
            {
                get
                {
                    return ongeldigeAankoopdatumValue;
                }
                set
                {
                    ongeldigeAankoopdatumValue = value;
                }
            }

            public OngeldigeAankoopdatumException(string message, DateTime ongeldigeAankoopdatum) : base(message)
            {
                OngeldigeAankoopdatum = ongeldigeAankoopdatum;
            }
        }

        public Kasbon(DateTime aankoopdatum, decimal bedrag, int looptijd, float intrest, Klant klant)
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
                if (value.Year < 1990)
                    throw new OngeldigeAankoopdatumException("Aankoopdatum mag niet vóór 1-1-1990 zijn!", value);
                aankoopdatumValue = value;
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
                if (value < 0)
                    throw new NegatiefBedragException("Bedrag mag niet negatief zijn!", value);
                bedragValue = value;
            }
        }

        private int looptijdValue;
        public int Looptijd
        {
            get
            {
                return looptijdValue;
            }
            set
            {
                if (value < 0)
                    throw new NegatieveLooptijdException("Looptijd mag niet negatief zijn!", value);
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
                if (value < 0)
                    throw new NegatiefIntrestException("Intrest mag niet negatief zijn!", value);
                intrestValue = value;
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
