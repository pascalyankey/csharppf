using System.Collections.Generic;
using VliegendPersoneelslid = FLYNET.Personeel.VliegendPersoneelslid;
using VliegMaatschappij = FLYNET.Vloot.VliegMaatschappij;
using Vliegtuig = FLYNET.Vloot.Vliegtuig;

namespace FLYNET
{
    public class Vlucht
    {
        public Vlucht(int vluchtID, string bestemming, int duurtijdindagen, VliegMaatschappij vliegmaatschappij, Vliegtuig toestel, List<VliegendPersoneelslid> personeel)
        {
            VluchtID = vluchtID;
            Bestemming = bestemming;
            DuurtijdInDagen = duurtijdindagen;
            VliegMaatschappij = vliegmaatschappij;
            Toestel = toestel;
            Personeel = personeel;
        }

        public int VluchtID { get; set; }
        public string Bestemming { get; set; }
        public int DuurtijdInDagen { get; set; }
        public VliegMaatschappij VliegMaatschappij { get; set; }
        public Vliegtuig Toestel { get; set; }
        public List<VliegendPersoneelslid> Personeel { get; set; }
        public decimal BerekenVluchtKost()
        {
            var totaal = 0m;

            totaal += Toestel.BerekenTotaleKostprijsPerDag() * DuurtijdInDagen;

            foreach (var persoon in Personeel)
                totaal += persoon.BerekenTotaleKostprijsPerDag() * DuurtijdInDagen;

            return totaal;
        }
    }
}
