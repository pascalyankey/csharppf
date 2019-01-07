using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graad = FLYNET.Enums.Graad;

namespace FLYNET.Personeel
{
    public abstract class VliegendPersoneelslid : Personeelslid
    {
        public VliegendPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, Graad graad, List<string> certificaten):base(personeelsid, naam, basiskostprijsperdag)
        {
            Graad = graad;
            Certificaten = certificaten;
        }
        public VliegendPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, Graad graad) : base(personeelsid, naam, basiskostprijsperdag)
        {
            Graad = graad;
        }

        public VliegendPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, List<string> certificaten) : base(personeelsid, naam, basiskostprijsperdag)
        {
            Certificaten = certificaten;
        }
        public VliegendPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag) : base(personeelsid, naam, basiskostprijsperdag)
        {

        }

        public abstract Graad Graad { get; set; }

        public List<string> Certificaten { get; set; }

        public override decimal BerekenTotaleKostprijsPerDag()
        {
            return BasisKostprijsPerDag;
        }
    }
}
