using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Materiaal
{
    public delegate void Onderhoudsbeurt(Fotokopiemachine machine);
    public class Fotokopiemachine : IKost
    {
        public event Onderhoudsbeurt OnderhoudNodig;
        private const int AantalBlzTussen2OnderhoudsBeurten = 10;
        private int aantalGekopieerdeBlzValue;
        private decimal kostPerBlzValue;

        public void Fotokopieer(int aantalBlz)
        {
            for (int blz = 1; blz <= aantalBlz; blz++)
            {
                Console.WriteLine($"FotokopieMachine {SerieNr} kopieert " + $"blz. {blz} van {aantalBlz}");
                if (++AantalGekopieerdeBlz % AantalBlzTussen2OnderhoudsBeurten == 0)
                    if (OnderhoudNodig != null)
                        OnderhoudNodig(this);
            }
        }

        private string serieNrValue;
        public string SerieNr
        {
            get
            {
                return serieNrValue;
            }
            set
            {
                serieNrValue = value;
            }
        }

        public int AantalGekopieerdeBlz
        {
            get
            {
                return aantalGekopieerdeBlzValue;
            }
            set
            {
                if (value >= 0)
                    aantalGekopieerdeBlzValue = value;
            }
        }

        public decimal KostPerBlz
        {
            get
            {
                return kostPerBlzValue;
            }
            set
            {
                if (value > 0)
                    kostPerBlzValue = value;
            }
        }

        public Fotokopiemachine(string serieNr, int aantalGekopieerdeBlz, decimal kostPerBlz)
        {
            SerieNr = serieNr;
            AantalGekopieerdeBlz = aantalGekopieerdeBlz;
            KostPerBlz = kostPerBlz;
        }

        public bool Menselijk
        {
            get
            {
                return false;
            }
        }

        public decimal Bedrag
        {
            get
            {
                return AantalGekopieerdeBlz * KostPerBlz;
            }
        }
    }
}
