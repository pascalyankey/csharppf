using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Zichtrekening : Rekening
    {
        public class OngeldigMaxKredietException : Exception
        {
            private decimal ongeldigMaxKredietValue;
            public decimal OngeldigMaxKrediet
            {
                get
                {
                    return ongeldigMaxKredietValue;
                }
                set
                {
                    ongeldigMaxKredietValue = value;
                }
            }

            public OngeldigMaxKredietException(string message, decimal ongeldigMaxKrediet) : base(message)
            {
                OngeldigMaxKrediet = ongeldigMaxKrediet;
            }
        }

        public Zichtrekening(string rekeningnummer, decimal bedrag, DateTime creatiedatum, Klant klant, decimal maxkrediet):base(rekeningnummer, bedrag, creatiedatum, klant)
        {
            this.MaxKrediet = maxkrediet;
        }

        private decimal maxkredietValue;
        public decimal MaxKrediet
        {
            get
            {
                return maxkredietValue;
            }
            set
            {
                if (value >= 0)
                    throw new OngeldigMaxKredietException("Max krediet mag niet positief zijn!", value);
                maxkredietValue = value;
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Max krediet: {0}", MaxKrediet);
        }
    }
}
