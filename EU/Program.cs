using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EU
{
    class Program
    {
        static void Main(string[] args)
        {
            List<csatlakozas> orszagok = new List<csatlakozas>();
            foreach (var sor in File.ReadAllLines("EUcsatlakozas.txt"))orszagok.Add(new csatlakozas(sor));
            Console.WriteLine($"3.feladat: Az Eu tagállamainak száma: {orszagok.Count} db");
            Console.WriteLine($"4.feladat: 2007-ben {orszagok.Count(x=>x.datum.Year==2007)} ország csatlakozott.");
            csatlakozas hun = orszagok.Where(x => x.orsz == "Magyarország").First();
            Console.WriteLine($"5.feladat: Magyarország csatlakozásának a dátuma: {hun.datum:d}");
            Console.WriteLine($"6.feladat: Májusban {(orszagok.Any(x=>x.datum.Month==05)?"volt":"nem volt")} csatlakozás!");
            csatlakozas utolso = orszagok.OrderBy(x => x.datum.Year).Last();
            Console.WriteLine($"7.feladat: Legutoljára csatlakozott ország: {utolso.orsz}");
            Console.WriteLine($"8.feladat: Statisztika");
            orszagok.GroupBy(x => x.datum.Year).Select(x => new { d = x.Key, c = x.Count() }).ToList().ForEach(x => Console.WriteLine($"\t{x.d} - {x.c}"));
        }
    }
}
