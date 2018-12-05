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
            Klant klant = new Klant("Pascal", "Yankey");
            Rekening zichtrekening = new Zichtrekening("BE74 0016 1883 3707", 500, new DateTime(2018, 10, 4), klant, -2500);
            Rekening spaarrekening = new Spaarrekening("BE33 0358 9737 6646", 900, new DateTime(2018, 11, 4), klant, 5.4f);
            BankBediende eenBankBediende = new BankBediende("Anke", "Bollen");

            zichtrekening.RekeningUittreksel += eenBankBediende.ToonRekeningUittreksel;
            zichtrekening.SaldoInHetRood += eenBankBediende.ToonSaldoInHetRood;
            zichtrekening.Storten(100);
            zichtrekening.Afhalen(100);

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
