using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public delegate void Transactie(Rekening rekening);
    public abstract class Rekening : ISpaarmiddel
    {
        public class OngeldigRekeningnummerException : Exception
        {
            private string ongeldigRekeningnummerValue;
            public string OngeldigRekeningnummer
            {
                get
                {
                    return ongeldigRekeningnummerValue;
                }
                set
                {
                    ongeldigRekeningnummerValue = value;
                }
            }

            public OngeldigRekeningnummerException(string message, string ongeldigRekeningnummer) : base(message)
            {
                OngeldigRekeningnummer = ongeldigRekeningnummer;
            }
        }

        public class OngeldigeCreatieDatumException : Exception
        {
            private DateTime ongeldigeCreatieDatumValue;
            public DateTime OngeldigeCreatieDatum
            {
                get
                {
                    return ongeldigeCreatieDatumValue;
                }
                set
                {
                    ongeldigeCreatieDatumValue = value;
                }
            }

            public OngeldigeCreatieDatumException(string message, DateTime ongeldigeCreatieDatum) : base(message)
            {
                OngeldigeCreatieDatum = ongeldigeCreatieDatum;
            }
        }

        public event Transactie RekeningUittreksel;
        public event Transactie SaldoInHetRood;

        private decimal saldoValue;
        private decimal vorigsaldoValue;
        private decimal bedragValue;

        public Rekening(string rekeningnummer, decimal bedrag, DateTime creatiedatum, Klant klant)
        {
            this.Rekeningnummer = rekeningnummer;
            this.Saldo = bedrag;
            this.Creatiedatum = creatiedatum;
            this.Klant = klant;
        }

        private string rekeningnummerValue;
        public string Rekeningnummer
        {
            get
            {
                return rekeningnummerValue;
            }
            set
            {
                string reknr = value;
                reknr = reknr.Replace(" ", "");
                string landcode = reknr[0] + "" + reknr[1] + "" + reknr[2] + "" + reknr[3];
                string reknr2 = reknr.Substring(4, reknr.Length - 4);
                reknr2 = reknr + "" + landcode;
                int letterCijfer = (int)landcode[0] - 55;
                int letterCijfer2 = (int)landcode[1] - 55;
                string landcode2 = (letterCijfer + "" + letterCijfer2 + "" + landcode[2] + landcode[3]).ToString();
                reknr = reknr.Substring(4, reknr.Length - 4);
                string reknr3 = reknr + landcode2;
                long reknummer = long.Parse(reknr3);
                long res = reknummer % 97;
                if (res != 1)
                    throw new OngeldigRekeningnummerException("Ongeldig rekeningnummer!", value);
                rekeningnummerValue = value;
            }
        }

        private DateTime creatiedatumValue;
        public DateTime Creatiedatum
        {
            get
            {
                return creatiedatumValue;
            }
            set
            {
                if (value.Year < 1990)
                    throw new OngeldigeCreatieDatumException("Het jaar mag niet voor 1900 zijn!", value);
                creatiedatumValue = value;
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

        public void Storten(decimal bedrag)
        {
            bedragValue = bedrag;
            vorigsaldoValue = saldoValue;
            saldoValue += bedrag;
            if (RekeningUittreksel != null)
                RekeningUittreksel(this);
        }

        public void Afhalen(decimal bedrag)
        {
            bedragValue = bedrag;
            vorigsaldoValue = saldoValue;
            
            if (bedrag > saldoValue)
            {
                if (SaldoInHetRood != null)
                {
                    SaldoInHetRood(this);
                }
            } else
            {
                saldoValue -= bedrag;
                RekeningUittreksel(this);
            }
        }

        public decimal VorigSaldo
        {
            get
            {
                return vorigsaldoValue;
            }
        }

        public decimal Bedrag
        {
            get
            {
                return bedragValue;
            }
        }

        public decimal Saldo
        {
            get
            {
                return saldoValue;
            }
            set
            {
                saldoValue = value;
            }
        }

        public virtual void Afbeelden()
        {
            Console.WriteLine("Rekeningnummer: {0}", Rekeningnummer);
            Console.WriteLine("Saldo: {0}", Saldo);
            Console.WriteLine("Creatiedatum: {0}", Creatiedatum);
            Klant.Afbeelden();
        }
    }
}
