using System;
using System.Collections.Generic;

namespace PastaPizzaNET
{
    class Program
    {
        static void Main(string[] args)
        {
            var klant1 = new Klant(1, "Jan Janssen");
            var gerecht1 = new Pizza("Pizza Margherita", 8, new List<string> { "Tomatensaus", "Mozzarella" }, "Groot", new List<string> { "Kaas", "Look" });
            var drank1 = new Frisdrank("Water", 2);
            var dessert1 = new Dessert("Ijs", 3);
            var bestelling1 = new Bestelling(1, klant1, gerecht1, drank1, dessert1, 2);

            bestelling1.ToonDetails();
        }
    }
}
