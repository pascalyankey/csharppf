namespace FLYNET
{
    public interface IKost
    {
        decimal BasisKostprijsPerDag { get; set; }
        decimal BerekenTotaleKostprijsPerDag();
    }
}
