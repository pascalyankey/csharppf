﻿using System;

namespace PastaPizzaNET
{
    public abstract class Drank : IBedrag
    {
        public enum Dranken
        {
            Water = 200,
            Limonade = 200,
            Cocacola = 200,
            Koffie = 250,
            Thee = 250
        }

        public Drank(Dranken naam, float prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        private Dranken naamValue;
        public Dranken Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (Enum.IsDefined(typeof(Dranken), value))
                    naamValue = value;
                else
                    throw new Exception("Opgegeven drank staat niet in de lijst!");
            }
        }
        private float prijsValue;
        public float Prijs
        {
            get
            {
                return prijsValue;
            }
            set
            {
                prijsValue = (float)Naam / 100;
            }
        }

        public abstract float BerekenBedrag();
    }
}