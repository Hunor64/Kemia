using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            bool talalat = false;
            Console.WriteLine("6. Feladat: Keresés");
            foreach (var elem in felfedezeseks)
            {
                if (elem.Vegyjel.ToLower() == eredmeny.ToLower())
                {
                    Console.WriteLine($"\tAz elem vegyjele: {elem.Vegyjel}");
                    Console.WriteLine($"\tAz elem neve: {elem.Elem}");
                    Console.WriteLine($"\tRendzsáma: {elem.Rendszam}");
                    Console.WriteLine($"\tFelfedezés éve: {elem.Ev}");
                    Console.WriteLine($"\tFelfedező: {elem.Felfedezo}");
                    talalat = true;
                    break;
                }
            }
            if (!talalat)
            {
                Console.WriteLine("6. Feldat: Nincs ilyen elem az adatforrásban!");
            }

            //7
            //Kevésbé szép megoldás ki kommentelve
            /*
            int legKis = int.MaxValue;
            int legNagy = int.MinValue;*/
            List<int> evek = new List<int>();
            foreach (var item in felfedezeseks)
            {
                if (item.Ev != "Ókor")
                {
                    evek.Add(int.Parse(item.Ev));
                }
                /*
                if (item.Ev != "Ókor")
                {
                    if (int.Parse(item.Ev) > legNagy)
                    {
                        legNagy = int.Parse(item.Ev);
                    }
                    if (int.Parse(item.Ev) < legKis)
                    {
                        legKis = int.Parse(item.Ev);
                    }
                }
                */
            }
            /*
            Console.WriteLine($"{legNagy-legKis} év volt a leghosszabb idő két elem felfedezése között.");*/
            Console.WriteLine($"{evek.Max() - evek.Min()} év volt a leghosszabb idő két elem felfedezése között.");

            //8
            Console.WriteLine("8. Feladat: Statisztika");
            List<int> evekOsszes = new List<int>();
            foreach (var elem in felfedezeseks)
            {
                if (elem.Ev != "Ókor")
                {
                    if (evekOsszes.Contains(int.Parse(elem.Ev)))
                    {

                    }
                    else
                    {
                        evekOsszes.Add(int.Parse(elem.Ev));
                    }
                }
            }
            for (int i = 0; i < evekOsszes.Count; i++)
            {
                
            }

        }
    }
}
