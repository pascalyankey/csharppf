using System;
using System.Collections.Generic;
using Graad = FLYNET.Enums.Graad;
using CabinePersoneel = FLYNET.Enums.CabineBemanningslid;

namespace FLYNET.Personeel
{
    public class CabinePersoneelslid : VliegendPersoneelslid
    {
        public CabinePersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, Graad graad, List<Certificaat> certificaten, string werkpositie) : base(personeelsid, naam, basiskostprijsperdag, graad, certificaten)
        {
            Werkpositie = werkpositie;
        }
        public CabinePersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, Graad graad, List<Certificaat> certificaten) : base(personeelsid, naam, basiskostprijsperdag, graad, certificaten)
        {

        }
        public CabinePersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, Graad graad, string werkpositie) : base(personeelsid, naam, basiskostprijsperdag, graad)
        {
            Werkpositie = werkpositie;
        }
        public CabinePersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, List<Certificaat> certificaten, string werkpositie) : base(personeelsid, naam, basiskostprijsperdag, certificaten)
        {
            Werkpositie = werkpositie;
        }
        public CabinePersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag, string werkpositie) : base(personeelsid, naam, basiskostprijsperdag)
        {
            Werkpositie = werkpositie;
        }
        public CabinePersoneelslid(string personeelsid, string naam, decimal basiskostprijsperdag) : base(personeelsid, naam, basiskostprijsperdag)
        {

        }

        public string Werkpositie { get; set; }

        private Graad graadValue;
        public override Graad Graad
        {
            get
            {
                return graadValue;
            }
            set
            {
                if (Enum.IsDefined(typeof(CabinePersoneel), (CabinePersoneel)value))
                    graadValue = value;
                else
                    throw new GraadException(value, "behoort niet tot de mogelijke graden van een CabinePersoneelslid");
            }
        }

        public override decimal BerekenTotaleKostprijsPerDag()
        {
            var percentage = 0m;
            var totaal = 0m;

            if (Graad == Graad.Purser)
                percentage = 0.2m;

            totaal = BasisKostprijsPerDag + (BasisKostprijsPerDag * percentage);

            if (Certificaten != null)
            {
                foreach (var item in Certificaten)
                {
                    if (item.CertificaatAfkorting == "EHBO")
                        totaal += 5;
                }
            }

            return totaal;
        }
    }
}
