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
            foreach (var sor in File.ReadAllLines("EUcsatlakozas.txt"))
            {
                orszagok.Add(new csatlakozas(sor));
            }
            Console.WriteLine($"3.feladat: Az Eu tagállamainak száma: {orszagok.Count} db");
            Console.WriteLine($"4.feladat: 2007-ben {orszagok.Count(x=>x.datum.Year==2007)} ország csatlakozott.");
        }
    }
}
