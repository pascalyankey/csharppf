using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNET
{
    public enum Grootte
    {
        Klein=0,
        Groot=3
    }
    public enum Extra
    {
        Brood=1,
        Kaas=1,
        Look=1
    }
    public class BesteldGerecht : Gerecht
    {
        public Grootte Grootte { get; set; }
        public List<Extra> Extra { get; set; }
    }
}
