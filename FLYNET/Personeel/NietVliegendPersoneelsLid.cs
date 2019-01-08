using Afdeling = FLYNET.Enums.Afdeling;

namespace FLYNET.Personeel
{
    public class NietVliegendPersoneelsLid : Personeelslid
    {
        public NietVliegendPersoneelsLid(string personeelsid, string naam, decimal basiskostprijsperdag, int urenperweek, Afdeling afdeling) : base(personeelsid, naam, basiskostprijsperdag)
        {
            UrenPerWeek = urenperweek;
            Afdeling = afdeling;
        }
        public NietVliegendPersoneelsLid(string personeelsid, string naam, decimal basiskostprijsperdag, int urenperweek) : base(personeelsid, naam, basiskostprijsperdag)
        {
            UrenPerWeek = urenperweek;
        }
        public NietVliegendPersoneelsLid(string personeelsid, string naam, decimal basiskostprijsperdag, Afdeling afdeling) : base(personeelsid, naam, basiskostprijsperdag)
        {
            Afdeling = afdeling;
        }
        public NietVliegendPersoneelsLid(string personeelsid, string naam, decimal basiskostprijsperdag):base(personeelsid, naam, basiskostprijsperdag)
        {
            
        }

        public int UrenPerWeek { get; set; }
        public Afdeling Afdeling { get; set; }

        public override decimal BerekenTotaleKostprijsPerDag()
        {
            return BasisKostprijsPerDag;
        }
    }
}
