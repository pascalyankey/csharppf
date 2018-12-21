using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNET
{
    public class Pasta : Gerecht
    {
        public Pasta(string naam, float prijs, string omschrijving, string grootte, List<string> extra) : base(naam, prijs, grootte, extra)
        {
            Omschrijving = omschrijving;
        }

        public Pasta(string naam, float prijs, string omschrijving, string grootte) : base(naam, prijs, grootte)
        {
            Omschrijving = omschrijving;
        }

        public Pasta(string naam, float prijs, string grootte, List<string> extra) : base(naam, prijs, grootte, extra)
        {

        }

        public string Omschrijving { get; set; }

        public override float BerekenBedrag()
        {
            var totaalPrijs = 0f;

            totaalPrijs += (int)Enum.Parse(typeof(BesteldGerecht.Grootte), Grootte);

            if (Extra != null)
            {
                foreach (var item in Extra)
                {
                    totaalPrijs += (int)Enum.Parse(typeof(BesteldGerecht.Extra), item);
                }
            }

            totaalPrijs += Prijs;

            return totaalPrijs;
        }

        public override string ToString()
        {
            return Naam +" <" + Prijs + " euro> " + Omschrijving + " <" + Grootte + "> " + ShowExtra() + " <bedrag: " + BerekenBedrag() + " euro>";
        }

        public string ShowExtra()
        {
            if (Extra != null)
            {
                var teller = 0;
                var extraBuilder = new StringBuilder();
                extraBuilder.Append("extra: ");
                foreach (var item in Extra)
                {
                    teller++;
                    if (teller == Extra.Count)
                        extraBuilder.Append(Enum.Parse(typeof(BesteldGerecht.Extra), item));
                    else
                        extraBuilder.Append(Enum.Parse(typeof(BesteldGerecht.Extra), item) + " ");
                }
                return extraBuilder.ToString();
            }
            else
            {
                return "";
            }
        }

        public override string objectToString()
        {
            return "";
        }
    }
}
