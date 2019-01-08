using System;
using Graad = FLYNET.Enums.Graad;

namespace FLYNET.Personeel
{
    public class GraadException : Exception
    {
        public GraadException(Graad foutieveGraad, string message):base(message)
        {
            FoutieveGraad = foutieveGraad;
        }

        public Graad FoutieveGraad { get; set; }
    }
}
