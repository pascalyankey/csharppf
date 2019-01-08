using System.Collections.Generic;
using Maatschappij = FLYNET.Enums.Maatschappij;

namespace FLYNET.Vloot
{
    public class VliegMaatschappij
    {
        public VliegMaatschappij(int vliegmaatschappijID, Maatschappij vliegmaatschappijNaam, List<string> vloot)
        {
            VliegMaatschappijID = vliegmaatschappijID;
            VliegMaatschappijNaam = vliegmaatschappijNaam;
            Vloot = vloot;
        }
        public int VliegMaatschappijID { get; set; }
        public Maatschappij VliegMaatschappijNaam { get; set; }
        public List<string> Vloot { get; set; }
    }
}
