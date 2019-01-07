using System.Collections.Generic;

namespace PastaPizzaNET
{
    public abstract partial class Gerecht
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
        }
    }
}
