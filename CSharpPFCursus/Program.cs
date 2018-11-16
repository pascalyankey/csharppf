using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    public enum Seizoen
    {
        Lente, Zomer, Herfst, Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Werknemer ik = new Werknemer();
            ik.Naam = "Pascal";
            ik.Geslacht = Geslacht.Man;
            ik.InDienst = new DateTime(2018,11,16);
            Werknemer jij = new Werknemer();
            jij.Naam = "Jozef";
            jij.Geslacht = Geslacht.Man;
            jij.InDienst = new DateTime(2018, 11, 28);
            LijnenTrekker lijnenTrekker = new LijnenTrekker();
            ik.Afbeelden();
            lijnenTrekker.TrekLijn(30, '-');
            jij.Afbeelden();
            lijnenTrekker.TrekLijn(79, '=');
            lijnenTrekker.TrekLijn();
            lijnenTrekker.TrekLijn(10);
            lijnenTrekker.TrekLijn(teken: '*', lengte: 10);

            int eerste = 10, tweede = 20;
            Verwisselaar verwisselaar = new Verwisselaar();
            verwisselaar.VerwisselNaarAndereVariabelen(eerste, tweede, out int resultaat1, out int resultaat2);
            Console.WriteLine(resultaat1);
            Console.WriteLine(resultaat2);

            Omzetter omzetter = new Omzetter();
            Console.Write("Afstand in cm: ");
            double cm = double.Parse(Console.ReadLine());
            Console.WriteLine($"{omzetter.CmNaarInch(cm)} inches");
            LijnenTrekker lijnenTrekker = new LijnenTrekker();
            lijnenTrekker.TrekLijn();
            Console.Write("Afstand in inches: ");
            double inches = double.Parse(Console.ReadLine());
            Console.WriteLine($"{omzetter.InchNaarCm(inches)} cm");*/

            Werknemer ik = new Werknemer("Pascal", new DateTime(2018, 11, 7), Geslacht.Man);
            ik.Afbeelden();
            Werknemer jij = new Werknemer();
            jij.Afbeelden();
        }
    }
}
