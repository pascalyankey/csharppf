using System.Collections.Generic;

namespace PastaPizzaNET
{
    public class BesteldGerecht
    {
        public enum Grootte
        {
            Klein = 0,
            Groot = 3
        }
        public enum Extra
        {
            Brood = 1,
            Kaas = 1,
            Look = 1
        }
        public Grootte GerechtGrootte { get; set; }
        public List<Extra> GerechtExtra { get; set; }
    }
}
