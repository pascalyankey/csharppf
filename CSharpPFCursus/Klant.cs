using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    public partial class Klant
    {
        private string naam;

        public string Naam
        {
            get { return naam; }
            set { naam = value; NaamChanged(naam); }
        }

        partial void NaamChanged(string naam);

        partial void NaamChanged(string naam)
        {
            Console.WriteLine("Naam gewijzigd naar {0}.", naam);
        }
    }
}
