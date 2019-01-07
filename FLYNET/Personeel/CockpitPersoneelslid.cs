using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graad = FLYNET.Enums.Graad;
using CockpitPersoneel = FLYNET.Enums.CockpitBemanningslid;

namespace FLYNET.Personeel
{
    public class CockpitPersoneelslid : VliegendPersoneelslid
    {
        public CockpitPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, Graad graad, List<string> certificaten, int vlieguren):base(personeelsid, naam, basiskostprijsperdag, graad, certificaten)
        {
            VliegUren = vlieguren;
        }
        public CockpitPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, Graad graad, List<string> certificaten) : base(personeelsid, naam, basiskostprijsperdag, graad, certificaten)
        {
        }
        public CockpitPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, Graad graad, int vlieguren) : base(personeelsid, naam, basiskostprijsperdag, graad)
        {
            VliegUren = vlieguren;
        }
        public CockpitPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, List<string> certificaten, int vlieguren) : base(personeelsid, naam, basiskostprijsperdag, certificaten)
        {
            VliegUren = vlieguren;
        }
        public CockpitPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, int vlieguren) : base(personeelsid, naam, basiskostprijsperdag)
        {
            VliegUren = vlieguren;
        }
        public CockpitPersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag) : base(personeelsid, naam, basiskostprijsperdag)
        {

        }

        public int VliegUren { get; set; }

        private Graad graadValue;
        public override Graad Graad
        {
            get
            {
                return graadValue;
            }
            set
            {
                if (Enum.IsDefined(typeof(CockpitPersoneel), value))
                    graadValue = value;
                else
                    throw new GraadException(value, "behoort niet tot de mogelijke graden van een CockpitPersoneelslid");
            }
        }

        public override decimal BerekenTotaleKostprijsPerDag()
        {
            var percentage = 0m;
            var totaal = 0m;

            if (Graad == Graad.Captain)
                percentage = 0.3m;
            if (Graad == Graad.SeniorFlightOfficer)
                percentage = 0.2m;
            if (Graad == Graad.SecondOfficer)
                percentage = 0.1m;

            totaal = BasisKostprijsPerDag + (BasisKostprijsPerDag * percentage);

            if (Certificaten != null)
            {
                foreach (var item in Certificaten)
                {
                    if (item == "CPL")
                        totaal += 50;
                }
            }
                
            return totaal;
        }
    }
}
