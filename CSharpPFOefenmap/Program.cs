using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class Program
    {
        const float GemLichTempCelsius = 37.0f;
        const int AantalSeconden = 3736;

        static void Main(string[] args)
        {
            //Conversie Celsius -> Fahrenheit
            //ConvertCelsiusFahrenheit();

            //Omrekening seconden
            //SecondenOmrekening();

            //Kortingsbon
            //ShowDiscountCalc();

            //Lichtkrant
            //ShowHoursMessage();

            //Kleinste, grootste en gemiddelde
            //ShowMinMaxAvg();

            //IBAN rekeningnummer generator
            //IBANRekeningNummerGenerator();

            //Controle IBAN rekeningnummer
            //IBANRekeningNummerControle();

            //Codeerprogramma
            //CodeerProgramma();

            //Bank
            /*Klant klant = new Klant("Pascal", "Yankey");
            try
            {
                Rekening zichtrekening = new Zichtrekening("BE74 0016 1883 3707", 500, new DateTime(2018, 10, 4), klant, -2500);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            //Voertuigen
            /*IPrivaat[] privaten = new IPrivaat[2];

            privaten[0] = new Vrachtwagen("Pascal Yankey", "1-BPU-729", 13700, 69, 6.5f);
            privaten[1] = new Personenwagen("Pascal Yankey", "1-BPU-729", 13700, 69, 6.5f);

            foreach (IPrivaat privaat in privaten)
                Console.WriteLine(privaat.GeefPrivateData());

            IMilieu[] milieus = new IMilieu[2];

            milieus[0] = new Vrachtwagen("Pascal Yankey", "1-BPU-729", 13700, 69, 6.5f);
            milieus[1] = new Personenwagen("Pascal Yankey", "1-BPU-729", 13700, 69, 6.5f);

            foreach (IMilieu milieu in milieus)
                Console.WriteLine(milieu.GeefMilieuData());*/

            //Lambda expressies
            //LambdaExpressies();

            //LINQ
            //Link();

            //Twitter
            Twitter();

        }

        private static void Twitter()
        {
            char keuze;
            string naam;
            string bericht;
            DateTime tijdstip;
            var twitter = new Twitter();

            Console.WriteLine("Maak een keuze:");
            Console.WriteLine("A: Twitterbericht plaatsen");
            Console.WriteLine("B: Toon alle twitterberichten");
            Console.WriteLine("C: Toon twitterberichten van een specifieke persoon");

            switch (keuze = Char.Parse(Console.ReadLine()))
            {
                case 'A':
                    Console.Write("Gebruikersnaam: ");
                    naam = Console.ReadLine().ToString();
                    Console.Write("Bericht (max.: 280 tekens): ");
                    bericht = Console.ReadLine().ToString();
                    tijdstip = DateTime.Now;
                    var tweet = new Tweet { Naam = naam, Bericht = bericht, Tijdstip = tijdstip };
                    twitter.PostBericht(tweet);
                    break;
                case 'B':
                    twitter.ToonBerichten();
                    break;
                case 'C':
                    Console.Write("Gebruikersnaam: ");
                    naam = Console.ReadLine().ToString();
                    twitter.ToonBerichten(naam);
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }
        }

        private static void Link()
        {
            var planten = new List<Plant>
            {
                new Plant {PlantId = 1, Plantennaam = "Tulp", Kleur = "rood", Prijs = 0.50m, Soort = "bol"},
                new Plant {PlantId = 2, Plantennaam = "Krokus", Kleur = "wit", Prijs = 0.20m, Soort = "bol"},
                new Plant {PlantId = 3, Plantennaam = "Narcis", Kleur = "geel", Prijs = 0.30m, Soort = "bol"},
                new Plant {PlantId = 4, Plantennaam = "Blauw druifje", Kleur = "blauw", Prijs = 0.20m, Soort = "bol"},
                new Plant {PlantId = 5, Plantennaam = "Azalea", Kleur = "rood", Prijs = 3.00m, Soort = "heester"},
                new Plant {PlantId = 6, Plantennaam = "Forsythia", Kleur = "geel", Prijs = 2.00m, Soort = "heester"},
                new Plant {PlantId = 7, Plantennaam = "Magnolia", Kleur = "wit", Prijs = 4.00m, Soort = "heester"},
                new Plant {PlantId = 8, Plantennaam = "Waterlelie", Kleur = "wit", Prijs = 2.00m, Soort = "water"},
                new Plant {PlantId = 9, Plantennaam = "Lisdodde", Kleur = "geel", Prijs = 3.00m, Soort = "water"},
                new Plant {PlantId = 10, Plantennaam = "Kalmoes", Kleur = "geel", Prijs = 2.50m, Soort = "water"},
                new Plant {PlantId = 11, Plantennaam = "Bieslook", Kleur = "paars", Prijs = 1.50m, Soort = "kruid"},
                new Plant {PlantId = 12, Plantennaam = "Rozemarijn", Kleur = "blauw", Prijs = 1.25m, Soort = "kruid"},
                new Plant {PlantId = 13, Plantennaam = "Munt", Kleur = "wit", Prijs = 1.10m, Soort = "kruid"},
                new Plant {PlantId = 14, Plantennaam = "Dragon", Kleur = "wit", Prijs = 1.30m, Soort = "kruid"},
                new Plant {PlantId = 15, Plantennaam = "Basilicum", Kleur = "wit", Prijs = 1.50m, Soort = "kruid"}
            };

            //Toon plantennaam, kleur en prijs van de witte planten, gesorteerd op prijs
            Console.WriteLine("=== WITTE PLANTEN ===");
            var wittePlanten = from plant in planten where plant.Kleur == "wit" orderby plant.Prijs select plant;
            foreach (var plant in wittePlanten)
                Console.WriteLine($"{plant.Plantennaam} {plant.Kleur} {plant.Prijs}");
            Console.WriteLine();
            //Toon het aantal witte planten
            Console.WriteLine($"Aantal witte planten: {planten.Count(plant => plant.Kleur == "wit")}");
            Console.WriteLine();

            //Bereken de gemiddelde prijs van de heesters en toon deze op het scherm
            var heesterPlanten = from plant in planten where plant.Soort == "heester" select plant;
            Console.WriteLine($"Gemiddelde heester prijs: {heesterPlanten.Average(plant => plant.Prijs)}");
            Console.WriteLine();

            //Toon de gemiddelde prijs en de maximumprijs van de kruiden
            var kruidPlanten = from plant in planten where plant.Soort == "kruid" select plant;
            Console.WriteLine($"Gemiddelde kruidplant prijs: {kruidPlanten.Average(plant => plant.Prijs)}");
            Console.WriteLine($"Maximum kruidplant prijs: {kruidPlanten.Max(plant => plant.Prijs)}");
            Console.WriteLine();

            //Toon de plantennamen die met de letter “B” beginnen
            Console.WriteLine("=== PLANTENNAMEN DIE BEGINNEN MET LETTER 'B' ===");
            var letterBPlanten = from plant in planten where plant.Plantennaam.StartsWith("B") select plant;
            foreach (var plant in letterBPlanten)
                Console.WriteLine(plant.Plantennaam);
            Console.WriteLine();

            //Toon een lijst van de verschillende plantenkleuren op het scherm
            Console.WriteLine("=== VERSCHILLENDE PLANTENKLEUREN ===");
            var soortenPlantenkleur = from plant in planten group plant by plant.Kleur;
            foreach (var soort in soortenPlantenkleur)
                Console.WriteLine(soort.Key);
            Console.WriteLine();

            //Toon de plantennamen per kleur op het scherm
            Console.WriteLine("=== PLANTENNAMEN PER KLEUR ===");
            foreach (var soort in soortenPlantenkleur)
            {
                Console.WriteLine($"=== {soort.Key} ===");
                foreach (var plant in soort)
                    Console.WriteLine(plant.Plantennaam);
            }
            Console.WriteLine();

            //Toon per soort de maximum plantenprijs van die soort
            Console.WriteLine("=== MAXIMUM PLANTENPRIJS PER SOORT ===");
            var soortPlantMaxPrijs = from plant in planten group plant by plant.Soort into soortPrijs select new { PlantSoort = soortPrijs.Key, MaxPrijs = soortPrijs.Max(x => x.Prijs) };
            foreach (var soort in soortPlantMaxPrijs)
                Console.WriteLine($"{soort.PlantSoort}: {soort.MaxPrijs}");
            Console.WriteLine();

            //Toon de soorten alfabetisch met per soort aantal planten + namen
            Console.WriteLine("=== SOORTEN PLANTEN ALFABETISCH (+ AANTAL + NAMEN) ===");
            var soortenPlanten = from plant in planten orderby plant.Soort group plant by plant.Soort into soortPlant select new { PlantSoort = soortPlant.Key, AantalPlanten = soortPlant.Count(), PlantNamen = soortPlant };
            foreach (var soort in soortenPlanten)
            {
                Console.WriteLine($"=== {soort.AantalPlanten} {soort.PlantSoort}planten  ===");
                foreach (var plant in soort.PlantNamen)
                    Console.WriteLine(plant.Plantennaam);
            }
            Console.WriteLine();

            //Toon de namen van de planten gegroepeerd per soort en binnen de soort per kleur
            Console.WriteLine("=== PLANTENNAMEN PER SOORT (> PER KLEUR) ===");
            var soortPlantSoortKleur = from plant in planten group plant by plant.Soort into soortPlant select new { SoortPlant = soortPlant.Key, SoortKleur = from plant2 in soortPlant group plant2 by plant2.Kleur into soortKleur select new { SoortKleur2 = soortKleur.Key, PlantNamen = from plant3 in soortKleur select plant3.Plantennaam } };
            foreach(var soort in soortPlantSoortKleur)
            {
                Console.WriteLine($"### {soort.SoortPlant.ToUpper()} ###");
                foreach (var soortKleur in soort.SoortKleur)
                {
                    Console.WriteLine($"--- {soortKleur.SoortKleur2} ---");
                    foreach (var plantnaam in soortKleur.PlantNamen)
                        Console.WriteLine(plantnaam);
                }
            }
        }

        private static void LambdaExpressies()
        {
            Func<int, bool> EvenGetallen = getal => getal % 2 == 0;
            Func<int, bool> OnevenGetallen = getal => getal % 2 == 1 || getal % 2 == -1;
            Func<int, bool> PositieveGetallen = getal => getal >= 0;
            Func<int, bool> NegatieveGetallen = getal => getal < 0;
            Action<int> ToonEvenGetallen = getal => Console.Write(getal + " ");
            Action<int> ToonOnevenGetallen = getal => Console.Write(getal + " ");
            Action<int> ToonPositieveGetallen = getal => Console.Write(getal + " ");
            Action<int> ToonNegatieveGetallen = getal => Console.Write(getal + " ");

            var getallen = new[] { -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -12 };

            Console.Write("Array: ");
            foreach (var getal in getallen)
                Console.Write(getal + " ");
            Console.WriteLine();

            Console.Write("Even: ");
            foreach (var getal in getallen)
            {
                if (EvenGetallen(getal))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    ToonEvenGetallen(getal);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.Write("Oneven: ");
            foreach (var getal in getallen)
            {
                if (OnevenGetallen(getal))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    ToonOnevenGetallen(getal);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.Write("Positief: ");
            foreach (var getal in getallen)
            {
                if (PositieveGetallen(getal))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    ToonPositieveGetallen(getal);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.Write("Negatief: ");
            foreach (var getal in getallen)
            {
                if (NegatieveGetallen(getal))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    ToonNegatieveGetallen(getal);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        private static void ConvertCelsiusFahrenheit()
        {
            //Conversie Celsius -> Fahrenheit
            float res = GemLichTempCelsius * 9 / 5 + 32;
            Console.WriteLine(GemLichTempCelsius + " Celius - " + res + " Fahrenheit");
        }

        private static void SecondenOmrekening()
        {
            //Omrekening seconden
            int uren, minuten, seconden;
            uren = AantalSeconden / 60 / 60;
            minuten = AantalSeconden / 60 % 60;
            seconden = AantalSeconden % 60;
            Console.WriteLine(AantalSeconden + " seconden - U:" + uren +
                " M:" + minuten + " S:" + seconden);
        }

        private static void ShowDiscountCalc()
        {
            //Kortingsbon
            Console.WriteLine("Voer een aankoopbedrag in");
            float korting = 0;
            float waarde = 0;
            float aankoopBedrag = float.Parse(Console.ReadLine());

            if (aankoopBedrag <= 25)
            {
                korting = 0.01f;
            }
            else if (aankoopBedrag > 25 && aankoopBedrag <= 50)
            {
                korting = 0.02f;
            }
            else if (aankoopBedrag > 50 && aankoopBedrag <= 100)
            {
                korting = 0.03f;
            }
            else
            {
                korting = 0.05f;
            }

            waarde = aankoopBedrag - (aankoopBedrag * korting);

            switch (korting)
            {
                case 0.01f:
                case 0.02f:
                case 0.03f:
                case 0.05f:
                    Console.WriteLine($"Uw korting is {korting} en de waarde van uw aankoopbedrag is {waarde}");
                    break;
            }
        }

        private static void ShowHoursMessage()
        {
            string weekMessage = "We wensen u een prettige werkdag!";
            string weekendMessage = "We wensen u een fijn weekend!";

            Console.WriteLine("Geef een datum in (dd/MM/YYYY):");
            DateTime datum = DateTime.Parse(Console.ReadLine());

            switch (datum.DayOfWeek.ToString())
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Openingsuren: 9u00 tot 12-00 en van 13u00 tot 18u00");
                    Console.WriteLine(weekMessage);
                    break;
                case "Saturday":
                    Console.WriteLine("Openingsuren: 10u00 tot 12-00");
                    Console.WriteLine(weekendMessage);
                    break;
                case "Sunday":
                    Console.WriteLine("Gesloten");
                    Console.WriteLine(weekendMessage);
                    break;
                default:
                    break;
            }
        }

        private static void ShowMinMaxAvg()
        {
            int kleinste, grootste, getal, temp;
            int teller = 0;
            int som = 0;
            float gem = 0;

            Console.WriteLine("Voer een aantal positieve getallen in");
            Console.Write("Getal: ");
            kleinste = int.Parse(Console.ReadLine());
            if (kleinste != -1)
            {
                teller++;
                som += kleinste;
            }
            Console.Write("Getal: ");
            grootste = int.Parse(Console.ReadLine());
            if (grootste != -1)
            {
                teller++;
                som += grootste;
            }
            if (kleinste > grootste)
            {
                temp = grootste;
                grootste = kleinste;
                kleinste = temp;
                
            }
            do
            {
                Console.Write("Getal: ");
                getal = int.Parse(Console.ReadLine());

                if (getal != -1)
                {
                    teller++;
                    som += getal;

                    if (getal < kleinste)
                    {
                        kleinste = getal;
                    }
                    if (getal > grootste)
                    {
                        grootste = getal;
                    }
                } else
                {
                    break;
                }
            } while (getal != -1);

            if (teller == 0)
            {
                Console.WriteLine("Delen door 0 is niet mogelijk");

            } else {
                gem = som / teller;
                Console.WriteLine($"Het kleinste getal is {kleinste}, het grootste getal is {grootste} en het gemiddelde is {gem}");
            }
        }

        private static void IBANRekeningNummerGenerator()
        {
            string reknr = "739-0102134-91";
            reknr = reknr.Replace("-", "");
            string landcode = "BE00";
            int letterCijfer = (int)landcode[0] - 55;
            int letterCijfer2 = (int)landcode[1] - 55;
            string landcode2 = (letterCijfer + "" + letterCijfer2 + "" + landcode[2] + landcode[3]).ToString();
            string reknr2 = reknr + landcode2;
            long reknummer = long.Parse(reknr2);
            long res = 98 - (reknummer % 97);

            if (res < 10)
            {
                reknr = landcode[0] + "" + landcode[1] + "0" + res + "" + reknr;
            } else
            {
                reknr = landcode[0] + "" + landcode[1] + "" + res + "" + reknr;
            }
            string deel1 = reknr[0] + "" + reknr[1] + "" + reknr[2] + "" + reknr[3];
            string deel2 = reknr[4] + "" + reknr[5] + "" + reknr[6] + "" + reknr[7];
            string deel3 = reknr[8] + "" + reknr[9] + "" + reknr[10] + "" + reknr[11];
            string deel4 = reknr[12] + "" + reknr[13] + "" + reknr[14] + "" + reknr[15];
            Console.WriteLine(deel1 + " " + deel2 + " " + deel3 + " " + deel4);
        }

        private static void IBANRekeningNummerControle()
        {
            string reknr = "BE73 0631 5475 6360";
            reknr = reknr.Replace(" ","");
            string landcode = reknr[0] + "" + reknr[1] + "" + reknr[2] + "" + reknr[3];
            string reknr2 = reknr.Substring(4, reknr.Length - 4);
            reknr2 = reknr + "" + landcode;
            int letterCijfer = (int)landcode[0] - 55;
            int letterCijfer2 = (int)landcode[1] - 55;
            string landcode2 = (letterCijfer + "" + letterCijfer2 + "" + landcode[2] + landcode[3]).ToString();
            reknr = reknr.Substring(4, reknr.Length - 4);
            string reknr3 = reknr + landcode2;
            long reknummer = long.Parse(reknr3);
            long res = reknummer % 97;
            if (res == 1)
            {
                Console.WriteLine("Geldig IBAN rekeningnummer");
            } else
            {
                Console.WriteLine("Ongeldig IBAN rekeningnummer!");
            }
        }

        private static void CodeerProgramma()
        {
            char[] alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] sleutel = "QSPATVXBCRJYEDUOHZGIFLNWKM".ToCharArray();

            Console.WriteLine("Voer een tekst in");
            string tekst = Console.ReadLine();

            tekst = tekst.ToUpper();

            char[] omgezet = new char[tekst.Length];

            for (int i = 0; i < tekst.Length; i++)
            {
                int index = Array.IndexOf(alfabet, tekst[i]);
                if (index > -1) {
                    omgezet[i] = sleutel[index];
                } else {
                    omgezet[i] = tekst[i];
                }
            }
            Console.WriteLine(omgezet);
        }
    }
}
