using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    [Serializable]
    public class Tweet
    {
        public string Naam { get; set; }
        private string berichtValue;
        public string Bericht
        {
            get
            {
                return berichtValue;
            }
            set
            {
                if (value.Length <= 280)
                    berichtValue = value;
                else
                    throw new Exception("Bericht mag max. 280 tekens bevatten.");
            }
        }
        public DateTime Tijdstip { get; set; }

        public override string ToString()
        {
            return this.Naam + ": " + this.Bericht + " - " + this.Tijdstip;
        }
    }
}
