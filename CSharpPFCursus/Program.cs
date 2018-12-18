using System;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("method Main is gestart...");
            Start();
            Console.WriteLine("terug in method Main");
            Console.WriteLine("druk een willekeurige toets als je de melding \"De taak is afgewerkt.\" ziet ...");
            Console.WriteLine();
            Console.ReadKey();
        }

        static async void Start()
        {
            Console.WriteLine("method Start is gestart...");
            string tekst = await DoeIetsAsync();
            Console.WriteLine(tekst);
        }

        static async Task<string> DoeIetsAsync()
        {
            Console.WriteLine("Bezig met taak ...DoeIetsAsync");
            await Task.Delay(5000);
            return "De taak is afgewerkt.";
        }
    }
}