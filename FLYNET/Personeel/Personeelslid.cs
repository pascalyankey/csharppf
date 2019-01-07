using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLYNET.Personeel
{
    public abstract class Personeelslid : IKost
    {
        public Personeelslid(string personeelsid, string naam, decimal basiskostprijsperdag)
        {
            PersoneelsID = personeelsid;
            Naam = naam;
            BasisKostprijsPerDag = basiskostprijsperdag;
        }

        public decimal BasisKostprijsPerDag { get; set; }
        string PersoneelsID { get; set; }
        string Naam { get; set; }

        public abstract decimal BerekenTotaleKostprijsPerDag();
    }
}
