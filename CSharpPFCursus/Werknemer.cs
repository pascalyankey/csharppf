using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    public class Werknemer
    {
        /*
        public Werknemer(): this("Onbekend", DateTime.Today, Geslacht.Man)
        {
        }
        */
        public Werknemer (string naam, DateTime inDienst, Geslacht geslacht)
        {
            this.Naam = naam;
            this.InDienst = inDienst;
            this.Geslacht = geslacht;
        }

        private string naamValue;
        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != string.Empty)
                {
                    naamValue = value;
                }
            }
        }
        private DateTime inDienstValue;

        public DateTime InDienst
        {
            get { return inDienstValue; }
            set { inDienstValue = value; }
        }

        private Geslacht geslachtValue;

        public Geslacht Geslacht
        {
            get
            {
                return geslachtValue;
            }
            set
            {
                geslachtValue = value;
            }
        }

        private decimal salarisValue;

        public decimal Salaris
        {
            get
            {
                return salarisValue;
            }
            private set
            {
                if (value >= 0m)
                {
                    salarisValue = value;
                }
            }
        }

        public bool VerjaarAncien
        {
            get
            {
                return inDienstValue.Month == DateTime.Today.Month && inDienstValue.Day == DateTime.Today.Day;
            }
        }

        public void Afbeelden()
        {
            Console.WriteLine("Naam: {0}", Naam);
            Console.WriteLine("Geslacht: {0}", Geslacht);
            Console.WriteLine("In dienst: {0}", InDienst);
        }
    }
}
