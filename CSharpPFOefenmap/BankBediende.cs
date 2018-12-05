using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class BankBediende
    {
        public BankBediende(string voornaam, string naam)
        {
            Voornaam = voornaam;
            Naam = naam;
        }

        public void ToonRekeningUittreksel(Rekening rekening)
        {
            Console.WriteLine($"Rekeningnummer: {rekening.Rekeningnummer}");
            Console.WriteLine($"Vorig saldo: {rekening.VorigSaldo}");
            Console.WriteLine($"Bedrag storting/afhaling: {rekening.Bedrag}");
            Console.WriteLine($"Nieuw saldo: {rekening.Saldo}");
        }

        public void ToonSaldoInHetRood(Rekening rekening)
        {
            if (rekening.Bedrag > rekening.Saldo)
                Console.WriteLine($"Het maximum af te halen bedrag is {rekening.Saldo}");
        }

        private string voornaamValue;
        public string Voornaam
        {
            get
            {
                return voornaamValue;
            }
            set
            {
                voornaamValue = value;
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
                naamValue = value;
            }
        }
    }
}
