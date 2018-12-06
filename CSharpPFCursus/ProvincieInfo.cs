using System;
using System.IO;

namespace CSharpPFCursus
{
    public class ProvincieInfo
    {
        public int ProvincieGrootte(string provincieNaam)
        {
            using (StreamReader lezer = new StreamReader(@"C:\VS2017\provincies.txt"))
            {
                string regel;
                while ((regel = lezer.ReadLine()) != null)
                {
                    int dubbelPuntPos = regel.IndexOf(':');
                    string provincie = regel.Substring(0, dubbelPuntPos);
                    if (provincie == provincieNaam)
                        return int.Parse(regel.Substring(dubbelPuntPos + 1));
                }
            }
            throw new Exception("Onbestaande provincie: " + provincieNaam);
        }
    }
}
