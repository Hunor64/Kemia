using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
        class Felfedezesek
    {
        string ev;
        string elem;
        string vegyjel;
        int rendszam;
        string felfedezo;
        
        public Felfedezesek(string ev,string elem,string vegyjel,int rendszam,string felfedezo)
        {
            this.ev = ev;
            this.elem = elem;
            this.vegyjel = vegyjel;
            this.rendszam = rendszam;
            this.felfedezo = felfedezo;
        }
        public Felfedezesek(string sor)
        {
            var sorFelbontva = sor.Split(';');
            this.ev = sorFelbontva[0];
            this.elem = sorFelbontva[1];
            this.vegyjel = sorFelbontva[2];
            this.rendszam = int.Parse(sorFelbontva[3]);
            this.felfedezo = sorFelbontva[4];
        }
        public string Ev { get => ev; }
        public string Element { get => elem; }
        public string Vegyjel { get => vegyjel; }
        public int Rendszam { get => rendszam; }
        public string Felfedezo { get => felfedezo; }
        
    }
}
