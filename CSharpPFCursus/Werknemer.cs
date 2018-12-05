using System;
using Firma.Personeel;

namespace Firma.Personeel
{
    public abstract partial class Werknemer : IKost
    {
        public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man)
        {
        }

        public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
        {
            this.Naam = naam;
            this.InDienst = inDienst;
            this.Geslacht = geslacht;
        }

        public static void UitgebreideWerknemersLijst(Werknemer[] werknemers)
        {
            Console.WriteLine("Uitgebreide werknemerslijst:");
            foreach (Werknemer werknemer in werknemers)
                werknemer.Afbeelden();
        }

        public static void KorteWerknemersLijst(Werknemer[] werknemers)
        {
            Console.WriteLine("Verkorte werknemerslijst:");
            foreach (Werknemer werknemer in werknemers)
                Console.WriteLine(werknemer.ToString());
        }

        private WerkRegime regimeValue;
        public WerkRegime Regime
        {
            get
            {
                return regimeValue;
            }
            set
            {
                regimeValue = value;
            }
        }

        private DateTime[] verlofdagenValue;
        public DateTime[] Verlofdagen
        {
            get
            {
                return verlofdagenValue;
            }
            set
            {
                verlofdagenValue = value;
            }
        }

        private DateTime[] ziektedagenValue;
        public DateTime[] Ziektedagen
        {
            get
            {
                return ziektedagenValue;
            }
            set
            {
                ziektedagenValue = value;
            }
        }

        private Afdeling afdelingValue;
        public Afdeling Afdeling
        {
            get
            {
                return afdelingValue;
            }
            set
            {
                afdelingValue = value;
            }
        }

        public abstract decimal Premie
        {
            get;
        }

        static Werknemer()
        {
            Personeelsfeest = new DateTime(DateTime.Today.Year, 2, 1);
            while (Personeelsfeest.DayOfWeek != DayOfWeek.Friday)
                Personeelsfeest = Personeelsfeest.AddDays(1);
        }
        private static DateTime personeelsfeestValue;
        public static DateTime Personeelsfeest
        {
            set
            {
                personeelsfeestValue = value;
            }
            get
            {
                return personeelsfeestValue;
            }
        }

        private string naamValue;
        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != string.Empty)
                {
                    naamValue = value;
                }
            }
        }
        private DateTime inDienstValue;
        public DateTime InDienst
        {
            get { return inDienstValue; }
            set { inDienstValue = value; }
        }

        private Geslacht geslachtValue;
        public Geslacht Geslacht
        {
            get
            {
                return geslachtValue;
            }
            set
            {
                geslachtValue = value;
            }
        }

        private decimal salarisValue;
        public decimal Salaris
        {
            get
            {
                return salarisValue;
            }
            private set
            {
                if (value >= 0m)
                {
                    salarisValue = value;
                }
            }
        }

        public bool VerjaarAncien
        {
            get
            {
                return inDienstValue.Month == DateTime.Today.Month && inDienstValue.Day == DateTime.Today.Day;
            }
        }

        public abstract decimal Bedrag
        {
            get;
        }

        public bool Menselijk
        {
            get
            {
                return true;
            }
        }

        public virtual void Afbeelden()
        {
            Console.WriteLine("Naam: {0}", Naam);
            Console.WriteLine("Geslacht: {0}", Geslacht);
            Console.WriteLine("In dienst: {0}", InDienst);
            Console.WriteLine("Personeelsfeest: {0}", Personeelsfeest);
            if (Afdeling != null)
            {
                Console.WriteLine(Afdeling);
            }
        }

        public override string ToString()
        {
            return Naam + ' ' + Geslacht;
        }

        public override bool Equals(object obj)
        {
            if (obj is Werknemer)
            {
                Werknemer deAndere = (Werknemer)obj;
                return this.Naam == deAndere.Naam;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Naam.GetHashCode();
        }
    }
}
