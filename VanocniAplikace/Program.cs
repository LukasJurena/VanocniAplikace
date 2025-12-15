using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanocniAplikace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj jsem pomocník od santy, co si od něj přeješ?");
            string prani = Console.ReadLine();
            Console.WriteLine("Děkuji, santovi předám tvé přání: " + prani);
            Console.WriteLine("Přeji ti krásné Vánoce!");
            Console.WriteLine("..Santa si tvé přáníčko přečetl, ale jelikož si přes rok zlobil, tak dostaneš jenom uhlí Ho Ho ho.");
        }
    }
}
