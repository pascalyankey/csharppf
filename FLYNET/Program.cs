using System;
using System.Collections.Generic;
using System.Linq;
using Certificaat = FLYNET.Personeel.Certificaat;
using VliegendPersoneelslid = FLYNET.Personeel.VliegendPersoneelslid;
using CockpitPersoneelslid = FLYNET.Personeel.CockpitPersoneelslid;
using CabinePersoneelslid = FLYNET.Personeel.CabinePersoneelslid;
using Vliegtuig = FLYNET.Vloot.Vliegtuig;
using VliegMaatschappij = FLYNET.Vloot.VliegMaatschappij;
using Graad = FLYNET.Enums.Graad;
using Maatschappij = FLYNET.Enums.Maatschappij;

namespace FLYNET
{
    class Program
    {
        static void Main(string[] args)
        {
            var vluchten = new List<Vlucht>();

            //****************************************************************************************
            // Certificaten
            //****************************************************************************************

            Certificaat PPL = new Certificaat
            {
                CertificaatAfkorting = "PPL",
                CertificaatOmschrijving = "Private Pilot License"
            };

            Certificaat ATPL = new Certificaat
            {
                CertificaatAfkorting = "ATPL",
                CertificaatOmschrijving = "Airline Transport Pilot License"
            };

            Certificaat IR = new Certificaat
            {
                CertificaatAfkorting = "IR",
                CertificaatOmschrijving = "Instrument Rating"
            };

            Certificaat CPL = new Certificaat
            {
                CertificaatAfkorting = "CPL",
                CertificaatOmschrijving = "Commercial Pilot License"
            };

            Certificaat ME = new Certificaat
            {
                CertificaatAfkorting = "ME",
                CertificaatOmschrijving = "Multi Engine"
            };

            Certificaat MCC = new Certificaat
            {
                CertificaatAfkorting = "MCC",
                CertificaatOmschrijving = "Multi Crew Concept"
            };

            Certificaat EHBO = new Certificaat
            {
                CertificaatAfkorting = "EHBO",
                CertificaatOmschrijving = "First Aid"
            };

            Certificaat EVAC = new Certificaat
            {
                CertificaatAfkorting = "EVAC",
                CertificaatOmschrijving = "Evacution Procedures"
            };

            Certificaat FIRE = new Certificaat
            {
                CertificaatAfkorting = "FIRE",
                CertificaatOmschrijving = "Fire Fighting"
            };

            Certificaat SURV = new Certificaat
            {
                CertificaatAfkorting = "SURV",
                CertificaatOmschrijving = "Survival"
            };

            Certificaat IFS = new Certificaat
            {
                CertificaatAfkorting = "IFS",
                CertificaatOmschrijving = "In Flight Service"
            };

            //****************************************************************************************
            // Vliegend Personeel
            //****************************************************************************************

            var cockpit1 = new CockpitPersoneelslid("001", "Captain Kirk", 500, Graad.Captain, new List<Certificaat> { PPL, ATPL, CPL, SURV}, 5000);
            var cockpit2 = new CockpitPersoneelslid("002", "Spock", 400, Graad.SecondOfficer, new List<Certificaat> { PPL, ATPL, CPL, IFS }, 4500);
            var cabine1 = new CabinePersoneelslid("004", "Pavel Chekov", 300, Graad.Purser, new List<Certificaat> { ME, MCC, EHBO, IFS }, "deur1");
            var cabine2 = new CabinePersoneelslid("006", "SkyWalker", 300, Graad.Steward, new List<Certificaat> { FIRE, SURV, IFS, EHBO }, "nooduitgang");

            //****************************************************************************************
            // Vliegtuigen
            //****************************************************************************************

            var vliegtuig1 = new Vliegtuig("Boeing787", 913, 15700, 2000);
            var vliegtuig2 = new Vliegtuig("AntonovAn-30", 430, 1600, 300);
            var vliegtuig3 = new Vliegtuig("BritishAerospace146", 750, 1600, 600);
            var vliegtuig4 = new Vliegtuig("AntonovAn-225", 800, 15400, 1500);

            //****************************************************************************************
            // Vliegmaatschappijen
            //****************************************************************************************

            var maatschappij1 = new VliegMaatschappij(1, Maatschappij.BrusselsAirlines, new List<string> { "Boeing787", "BritishAerospace146" });
            var maatschappij2 = new VliegMaatschappij(2, Maatschappij.TNTAirways, new List<string> { "AntonovAn-30", "AntonovAn-225" });

            //****************************************************************************************
            // Vluchten
            //****************************************************************************************

            var vlucht1 = new Vlucht(1, "New York", 2, maatschappij1, vliegtuig1, new List<VliegendPersoneelslid> { cockpit1, cockpit2, cabine1, cabine2 });
            var vlucht2 = new Vlucht(2, "Beijing", 1, maatschappij2, vliegtuig4, new List<VliegendPersoneelslid> { cockpit1, cabine2 });
            var vlucht3 = new Vlucht(3, "Singapore", 2, maatschappij1, vliegtuig3, new List<VliegendPersoneelslid> { cockpit1, cabine2 });
            vluchten.Add(vlucht1);
            vluchten.Add(vlucht2);
            vluchten.Add(vlucht3);

            Console.WriteLine("Tonen gegevens van vluchten");
            Console.WriteLine("*************************************************************");

            //****************************************************************************************
            // Overzicht
            //****************************************************************************************

            foreach(var vlucht in vluchten)
            {
                Console.WriteLine($"ID = {vlucht.VluchtID}: Bestemming = {vlucht.Bestemming} (Duurtijd = {vlucht.DuurtijdInDagen} dag(en)) (Maatschappij = {vlucht.VliegMaatschappij.VliegMaatschappijNaam}) - (Toestel = {vlucht.Toestel.Type})");
                Console.WriteLine();
                Console.WriteLine($"Vluchtprijs = {vlucht.BerekenVluchtKost()}");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"VliegtuigKost per dag = {vlucht.Toestel.BerekenTotaleKostprijsPerDag()}");
                var totalePersoneelskostPerDag = vlucht.Personeel.Select(p => p.BerekenTotaleKostprijsPerDag()).Sum();
                Console.WriteLine($"Totale personeelskost per dag = {totalePersoneelskostPerDag}");
                Console.WriteLine("---------------------------------------------------------");

                foreach (var personeel in vlucht.Personeel)
                {
                    if (personeel is CockpitPersoneelslid)
                        Console.WriteLine("CockpitPersoneel:");
                    else
                        Console.WriteLine("CabinePersoneel:");
                    Console.WriteLine("---------------------------------");

                    Console.WriteLine($"PersoneelsID = {personeel.PersoneelsID}");
                    Console.WriteLine($"Naam = {personeel.Naam}");
                    Console.WriteLine($"BasiskostprijsPerDag = {personeel.BasisKostprijsPerDag}");
                    Console.WriteLine($"Certificaten = ");
                    foreach (var cert in personeel.Certificaten)
                        Console.WriteLine($"\t{cert.CertificaatOmschrijving} ({cert.CertificaatAfkorting})");
                    if (personeel is CockpitPersoneelslid)
                        Console.WriteLine($"Vlieguren = {personeel}");
                    else
                        Console.WriteLine($"Werkpositie = {personeel}");
                    Console.WriteLine($"Graad = {personeel.Graad}");
                    Console.WriteLine($"TotaleKostprijsPerDag = {personeel.BerekenTotaleKostprijsPerDag()}");
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------");
                }
                Console.WriteLine();
            }
        }
    }
}
