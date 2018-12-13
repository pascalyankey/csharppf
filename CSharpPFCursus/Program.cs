using System;
using Firma.Personeel;
using Firma.Materiaal;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace CSharpPFCursus
{
    class Program
    {
        static void Main(string[] args)
        {

            var pizzas = new List<Pizza>
            {
                new Pizza { Naam = "Pizza Margherita", Onderdelen = new List<string> {"Tomatensaus", "Mozzarella"}, Prijs = 8m },
                new Pizza { Naam = "Pizza Vegetariana", Onderdelen = new List<string> { "Tomatensaus", "Mozzarella", "Groenten" }, Prijs = 9.5m },
                new Pizza { Naam = "Pizza Napoli", Onderdelen = new List<string> { "Tomatensaus", "Mozzarella", "Ansjovis", "Kappers", "Olijven" }, Prijs = 10m }
            };

            try
            {
                //de verzameling wegschrijven
                using (var bestand = File.Open(@"C:\Data\Pizzas.obj", FileMode.OpenOrCreate))
                {
                    var schrijver = new BinaryFormatter();
                    schrijver.Serialize(bestand, pizzas);
                }

                //en terug inlezen
                using (var bestand = File.Open(@"C:\Data\Pizzas.obj", FileMode.Open, FileAccess.Read))
                {
                    var lezer = new BinaryFormatter();
                    pizzas = (List<Pizza>)lezer.Deserialize(bestand);
                    foreach (var pizza in pizzas)
                    {
                        Console.WriteLine(pizza.Naam);
                        foreach (var onderdeel in pizza.Onderdelen)
                            Console.WriteLine(onderdeel);
                        Console.WriteLine(pizza.Prijs);
                    }
                }
            }
            catch (IOException)
            {
               throw new Exception("Fout bij het openen van het bestand!");
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fout bij het serialiseren/deserialiseren");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            /* string locatie = @"C:\Data\";

             var pizzas = new List<Pizza>();

             string pizzaRegel;
             string pizzaNaam;
             int aantalOnderdelen;
             var pizzaOnderdelen = new List<string>();
             decimal prijs;

             //de pizzagegevens inlezen
             try
             {
                 using (var lezer = new StreamReader(locatie + "Pizzas.txt"))
                 {
                     while((pizzaRegel = lezer.ReadLine()) != null)
                     {
                         string[] gegevens = pizzaRegel.Split(new Char[] { ':' });
                         pizzaNaam = gegevens[0];
                         aantalOnderdelen = int.Parse(gegevens[1]);
                         pizzaOnderdelen = new List<string>();
                         for(var teller = 0; teller < aantalOnderdelen; teller++)
                         {
                             pizzaOnderdelen.Add(gegevens[teller + 2]);
                         }
                         prijs = decimal.Parse(gegevens[gegevens.Length - 1]);
                         pizzas.Add(new Pizza { Naam = pizzaNaam, Onderdelen = pizzaOnderdelen, Prijs = prijs });
                     }
                 }
             }
             catch (IOException)
             {
                 Console.WriteLine("Fout bij het lezen van het bestand!");
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }

             //de pizzagegevens tonen
             foreach(var pizza in pizzas)
             {
                 Console.WriteLine(pizza.ToString());
                 foreach(var onderdeel in pizza.Onderdelen)
                 {
                     Console.WriteLine(onderdeel);
                 }
                 Console.WriteLine();
             }*/

            /*string tekst = "Lottogetallen";
            int aantalGetallen = 45;
            byte[] lottogetallen = { 1, 27, 32, 33, 44, 12, 5 };
            float winst = 18f;
            string datum = DateTime.Now.ToShortDateString();
            using (BinaryWriter schrijver = new BinaryWriter(File.Open(@"C:\Data\Lottogetallen.bin", FileMode.Create)))
            {
                schrijver.Write(aantalGetallen);
                schrijver.Write(tekst);
                schrijver.Write(lottogetallen);
                schrijver.Write(winst);
                schrijver.Write(datum);
            }

            string tekst;
            int aantalGetallen;
            byte[] lottogetallen;
            float winst;
            string datum;

            using (var lezer = new BinaryReader(File.Open(@"C:\Data\Lottogetallen.bin", FileMode.Open)))
            {
                aantalGetallen = lezer.ReadInt32();
                tekst = lezer.ReadString();
                lottogetallen = lezer.ReadBytes(7);
                winst = lezer.ReadSingle();
                datum = lezer.ReadString();
            }

            Console.WriteLine(aantalGetallen);
            Console.WriteLine(tekst);
            foreach (byte lottogetal in lottogetallen)
                Console.Write($"{lottogetal} ");
            Console.WriteLine();
            Console.WriteLine(winst);
            Console.WriteLine(datum);*/
        }
    }
}