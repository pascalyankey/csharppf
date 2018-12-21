using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNET
{
    public class Pizza : Gerecht
    {
        public Pizza(string naam, float prijs, List<string> onderdelen, string grootte, List<string> extra) : base(naam, prijs, grootte, extra)
        {
            Onderdelen = onderdelen;
        }

        public Pizza(string naam, float prijs, List<string> onderdelen, string grootte) : base(naam, prijs, grootte)
        {
            Onderdelen = onderdelen;
        }

        public List<string> Onderdelen { get; set; }

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
            return Naam + " <" + Prijs + " euro> " + ShowOnderdelen() + " <" + Grootte + "> " + ShowExtra() + " <bedrag: " + BerekenBedrag() + " euro>";
        }

        public string ShowOnderdelen()
        {
            if (Onderdelen.Count >= 1)
            {
                var teller = 0;
                var pizzaBuilder = new StringBuilder();
                foreach (var item in Onderdelen)
                {
                    teller++;
                    if (teller == Onderdelen.Count)
                        pizzaBuilder.Append(item);
                    else
                        pizzaBuilder.Append(item + " - ");
                }
                return pizzaBuilder.ToString();
            } else
            {
                return "";
            }
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
                        extraBuilder.Append(item);
                    else
                        extraBuilder.Append(item + " ");
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
