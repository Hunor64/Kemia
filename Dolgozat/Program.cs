using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace Dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            List<Felfedezesek> felfedezeseks = new List<Felfedezesek>();
            string fileLocation = "felfedezesek.csv";
            var sorok = File.ReadAllLines(fileLocation);
            int index = 0;
            foreach (var elem in sorok)
            {
                if (index != 0)
                {
                    Felfedezesek uj = new Felfedezesek(elem);
                    felfedezeseks.Add(uj);
                }
                index++;
            }
            //3
            Console.WriteLine($"3. Feladat: Elemek száma: {felfedezeseks.Count}");

            //4
            int okorElemek = 0;
            foreach (var elem in felfedezeseks)
            {
                if (elem.Ev == "Ókor")
                {
                    okorElemek++;
                }
            }
            Console.WriteLine($"4. Feladat: Felfedezések száma az ókorban: {okorElemek}");

            //5
            string eredmeny;
            while (true)
            {
                Console.Write("5. Feladat: Kérek egy vegyjelet: ");
                eredmeny = Console.ReadLine();
                if (eredmeny.Length == 1 || eredmeny.Length == 2)
                {
                    break;
                }
            }

            //6
            foreach (var elem in felfedezeseks)
            {
                if (elem.Vegyjel.ToLower() == eredmeny.ToLower())
                {

                }
                else
                {
                    Console.WriteLine("6. Feldat: Nincs ilyen elem az adatforrásban!");
                }
            }
        }
    }
}
