namespace FLYNET.Vloot
{
    public class Vliegtuig : IKost
    {
        public Vliegtuig(string type, int kruissnelheid, int vliegbereik, decimal basiskostprijsperdag)
        {
            Type = type;
            Kruissnelheid = kruissnelheid;
            Vliegbereik = vliegbereik;
            BasisKostprijsPerDag = basiskostprijsperdag;
        }
        public string Type { get; set; }
        public int Kruissnelheid { get; set; }
        public int Vliegbereik { get; set; }
        public decimal BasisKostprijsPerDag { get; set; }

        public decimal BerekenTotaleKostprijsPerDag()
        {
            return BasisKostprijsPerDag;
        }
    }
}
