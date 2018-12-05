using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Stookketel : IVervuiler
    {
        public Stookketel(float conorm)
        {
            CONorm = conorm;
        }

        private float conormValue;
        public float CONorm
        {
            get
            {
                return conormValue;
            }
            set
            {
                conormValue = value;
            }
        }

        public double GeefVervuiling()
        {
            return CONorm * 100;
        }
    }
}
