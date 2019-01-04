using System;
using System.Collections.Generic;
using System.Linq;

namespace PastaPizzaNET
{
    class Program
    {
        static void Main(string[] args)
        {
            var bestellingen = new List<Bestelling>();
            var klant1 = new Klant(1, "Jan Janssen");
            var klant2 = new Klant(2, "Piet Peeters");
            var klant3 = new Klant();

            var gerecht1 = new Pizza("Pizza Margherita", 8, new List<string> { "Tomatensaus", "Mozzarella" }, "Groot", new List<string> { "Kaas", "Look" });
            var drank1 = new Frisdrank("Water", 2.0f);
            var dessert1 = new Dessert("Ijs", 3.0f);
            var bestelling1 = new Bestelling(1, klant1, gerecht1, drank1, dessert1, 2);
            bestellingen.Add(bestelling1);
            //bestelling1.ToonDetails();
            
            var gerecht2 = new Pizza("Pizza Margherita", 8, new List<string> { "Tomatensaus", "Mozzarella" }, "Klein");
            var drank2 = new Frisdrank("Water", 2.0f);
            var dessert2 = new Dessert("Tiramisu", 3.0f);
            var bestelling2 = new Bestelling(2, klant2, gerecht2, drank2, dessert2, 1);
            bestellingen.Add(bestelling2);
            //bestelling2.ToonDetails();

            var gerecht3 = new Pizza("Pizza Napoli", 10, new List<string> { "Tomatensaus", "Mozzarella", "Ansjovis", "Kappers", "Olijven" }, "Groot");
            var drank3 = new Warmedrank("Thee", 2.5f);
            var dessert3 = new Dessert("Ijs", 3.0f);
            var bestelling3 = new Bestelling(3, klant2, gerecht3, drank3, dessert3, 1);
            bestellingen.Add(bestelling3);
            //bestelling3.ToonDetails();

            var gerecht4 = new Pasta("Lasagne", 15, "Klein", new List<string> { "Look" });
            var bestelling4 = new Bestelling(4, klant3, gerecht4, 1);
            bestellingen.Add(bestelling4);
            //bestelling4.ToonDetails();

            var gerecht5 = new Pasta("Spaghetti Carbonara", 13, "spek, roomsaus en parmezaanse kaas" ,"Klein");
            var drank5 = new Frisdrank("CocaCola", 2.0f);
            var bestelling5 = new Bestelling(5, klant1, gerecht5, drank5, 1);
            bestellingen.Add(bestelling5);
            //bestelling5.ToonDetails();

            var gerecht6 = new Pasta("Spaghetti Bolognese", 12, "met gehaktsaus", "Groot", new List<string> { "Kaas" });
            var drank6 = new Frisdrank("CocaCola", 2.0f);
            var dessert6 = new Dessert("Cake", 2f);
            var bestelling6 = new Bestelling(6, klant2, gerecht6, drank6, dessert6, 1);
            bestellingen.Add(bestelling6);
            //bestelling6.ToonDetails();

            var drank7 = new Warmedrank("Koffie", 2.5f);
            var bestelling7 = new Bestelling(7, klant2, drank7, 3);
            bestellingen.Add(bestelling7);
            //bestelling7.ToonDetails();

            var dessert8 = new Dessert("Tiramisu", 3.0f);
            var bestelling8 = new Bestelling(8, klant1, dessert8, 1);
            bestellingen.Add(bestelling8);
            //bestelling8.ToonDetails();

            // Bestellingen en totaalbedrag van Jan Janssen
            var bestellingenJan = from bJan in bestellingen where bJan.Klant.Naam == "Jan Janssen" select bJan;
            var somJan = bestellingenJan.Select(b => b.BerekenBedrag()).Sum();
            Console.WriteLine($"Bestellingen van klant Jan Janssen:");
            Console.WriteLine();
            foreach (var item in bestellingenJan)
                item.ToonDetails();
            Console.WriteLine($"Het totaal bedrag van alle bestellingen van klant Jan Janssen: {somJan} euro");
            Console.WriteLine();
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine();

            // Bestellingen per klant + totaalbedrag bekende klanten
            var alleBestellingen = from alleB in bestellingen group alleB by alleB.Klant.Naam into bKlant select new { Klanten = bKlant.Key, Details = bKlant, Bedragen = bKlant.Select(bt => bt.BerekenBedrag()).Sum() };
            foreach (var klant in alleBestellingen)
            {
                if (klant.Klanten != "Onbekende klant")
                {
                    Console.WriteLine($"Bestellingen van klant {klant.Klanten}:");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Onbekende klanten:");
                    Console.WriteLine();
                }
                foreach (var item in klant.Details)
                    item.ToonDetails();
                if (klant.Klanten != "Onbekende klant")
                {
                    Console.WriteLine($"Het totaal bedrag van alle bestellingen van klant {klant.Klanten}: {klant.Bedragen} euro");
                    Console.WriteLine();
                    Console.WriteLine("*********************************************************************************");
                    Console.WriteLine();
                }
            }

            Console.WriteLine(bestelling1.ObjectToString());
            Console.WriteLine(bestelling2.ObjectToString());
            Console.WriteLine(bestelling3.ObjectToString());
            Console.WriteLine(bestelling4.ObjectToString());
            Console.WriteLine(bestelling5.ObjectToString());
            Console.WriteLine(bestelling6.ObjectToString());
            Console.WriteLine(bestelling7.ObjectToString());
            Console.WriteLine(bestelling8.ObjectToString());
        }
    }
}
