using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
