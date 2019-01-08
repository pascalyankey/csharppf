using System.Collections.Generic;
using Graad = FLYNET.Enums.Graad;

namespace FLYNET.Personeel
{
    public abstract class VliegendPersoneelslid : Personeelslid
    {
        public VliegendPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, Graad graad, List<Certificaat> certificaten):base(personeelsid, naam, basiskostprijsperdag)
        {
            Graad = graad;
            Certificaten = certificaten;
        }
        public VliegendPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, Graad graad) : base(personeelsid, naam, basiskostprijsperdag)
        {
            Graad = graad;
        }

        public VliegendPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, List<Certificaat> certificaten) : base(personeelsid, naam, basiskostprijsperdag)
        {
            Certificaten = certificaten;
        }
        public VliegendPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag) : base(personeelsid, naam, basiskostprijsperdag)
        {

        }

        public abstract Graad Graad { get; set; }

        public List<Certificaat> Certificaten { get; set; }

        public override decimal BerekenTotaleKostprijsPerDag()
        {
            return BasisKostprijsPerDag;
        }
    }
}
