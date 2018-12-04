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
            /*Afdeling afdeling1 = new Afdeling("Strijd", 0);
            Afdeling afdeling2 = new Afdeling("Feest", 1);

            Werknemer[] wij = new Werknemer[3];
            wij[0] = new Arbeider("Asterix", new DateTime(2018, 1, 1), Geslacht.Man, 24.79m, 3);
            wij[0].Afdeling = afdeling1;
            wij[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
            wij[1].Afdeling = afdeling1;
            wij[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);
            wij[2].Afdeling = afdeling2;
            foreach (Werknemer eenWerknemer in wij)
                eenWerknemer.Afbeelden();*/

            IKost[] kosten = new IKost[4];
            
            kosten[0] = new Arbeider("Asterix", new DateTime(2018, 1, 1), Geslacht.Man, 24.79m, 3);
            kosten[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
            kosten[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);
            kosten[3] = new Fotokopiemachine("123", 500, 0.025m);

            decimal totaleKost = 0m;
            foreach(IKost kost in kosten)
            {
                Console.WriteLine(kost.Menselijk);
                Console.WriteLine(kost.Bedrag);
                totaleKost += kost.Bedrag;
            }
            Console.WriteLine(totaleKost);
        }
    }
}
