using System;
using System.Collections.Generic;

namespace PastaPizzaNET
{
    public abstract partial class Gerecht : IBedrag
    {
        public Gerecht(string naam, float prijs, string grootte, List<string> extra)
        {
            Naam = naam;
            Prijs = prijs;
            Grootte = grootte;
            Extra = extra;
        }
        public Gerecht(string naam, float prijs, string grootte)
        {
            Naam = naam;
            Prijs = prijs;
            Grootte = grootte;
        }

        public string Naam { get; set; }
        public float Prijs { get; set; }
        private string grootteValue;
        public string Grootte
        {
            get
            {
                return grootteValue;
            }
            set
            {
                if (Enum.IsDefined(typeof(BesteldGerecht.Grootte), value))
                {
                    grootteValue = value;
                }
                else
                    throw new Exception("Opgegeven extra staat niet in de lijst!");
            }
        }
        private List<string> extraValue;
        public List<string> Extra
        {
            get
            {
                return extraValue;
            }
            set
            {
                if (extraValue == null)
                    extraValue = new List<string>();
                foreach(var item in value)
                {
                    if (Enum.IsDefined(typeof(BesteldGerecht.Extra), item))
                    {
                        extraValue.Add(item.ToString());
                    }
                    else
                        throw new Exception("Opgegeven extra staat niet in de lijst!");
                }
            }
        }

        public abstract float BerekenBedrag();
        public abstract string objectToString();
    }
}
