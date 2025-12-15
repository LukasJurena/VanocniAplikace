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
            Console.WriteLine("To je vše? Nechceš si přát ještě něco? [ano/ne]");
            while (true)
            {
                string odpoved = Console.ReadLine().ToLower();
                if (odpoved == "ano")
                {
                    Console.WriteLine("Tak co ještě chceš?");
                    string dalsiPrani = Console.ReadLine();
                    prani += ", " + dalsiPrani;
                    Console.WriteLine("Chceš si přát ještě něco?");
                }
                else if (odpoved == "ne")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Prosím odpověz 'ano' nebo 'ne'. Chceš si přát ještě něco?");
                }
            }
            Console.WriteLine("Děkuji, santovi předám tvé přání");
            Console.WriteLine("Přeji ti krásné Vánoce!");
            Console.WriteLine("..Santa si tvé přáníčko přečetl, ale jelikož si přes rok zlobil, tak dostaneš jenom uhlí, Ho Ho ho.");
        }
    }
}
