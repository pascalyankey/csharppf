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
        public string PersoneelsID { get; set; }
        public string Naam { get; set; }

        public abstract decimal BerekenTotaleKostprijsPerDag();
    }
}
