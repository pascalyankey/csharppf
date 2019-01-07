using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLYNET
{
    public class Enums
    {
        public enum Afdeling
        {
            Personeelsdienst,
            Boekhouding,
            Incheckbalie,
            Logistiek
        }

        public enum Graad
        {
            Captain,
            SeniorFlightOfficer,
            SecondOfficer,
            JuniorFlightOfficer,
            Steward,
            Purser
        }

        public enum Maatschappij
        {
            BrusselsAirlines,
            Jetairfly,
            ThomasCook,
            TNTAirways
        }

        public enum CockpitBemanningslid
        {
            Captain,
            SeniorFlightOfficer,
            SecondOfficer,
            JuniorFlightOfficer
        }

        public enum CabineBemanningslid
        {
            Purser,
            Steward
        }
    }
}
