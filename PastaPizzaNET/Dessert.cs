using System;

namespace PastaPizzaNET
{
    public class Dessert : IBedrag
    {
        public enum Desserten
        {
            Tiramisu = 3,
            Ijs = 3,
            Cake = 2
        }

        private Desserten naamValue;
        public Desserten Naam
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
                prijsValue = (int)Naam;
            }
        }

        public float BerekenBedrag()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Naam + " <" + Prijs + " euro>";
        }
    }
}
