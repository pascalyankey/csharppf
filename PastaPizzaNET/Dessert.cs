using System;

namespace PastaPizzaNET
{
    public class Dessert : IBedrag
    {
        public Dessert(string naam, int prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }
        public enum Desserten
        {
            Tiramisu = 3,
            Ijs = 3,
            Cake = 2
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
                if (Enum.IsDefined(typeof(Desserten), value))
                    naamValue = value;
                else
                    throw new Exception("Opgegeven dessert staat niet in de lijst!");
            }
        }
        private int prijsValue;
        public int Prijs
        {
            get
            {
                return prijsValue;
            }
            set
            {
                prijsValue = (int)Enum.Parse(typeof(Desserten), Naam);
            }
        }

        public float BerekenBedrag()
        {
            return Prijs;
        }

        public override string ToString()
        {
            return Naam + " <" + BerekenBedrag() + " euro>";
        }
    }
}
