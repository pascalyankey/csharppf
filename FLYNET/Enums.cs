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
            Steward = 4,
            Purser = 5
        }
    }
}
