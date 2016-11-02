using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga01
{
    class Knjiga
    {
        private string naslov;
        private string avtor;
        private int steviloStrani;

        public Knjiga()
        {
            naslov = null;
            avtor = null;
            steviloStrani = 0;
        }
        public Knjiga(int ste)
        {
            steviloStrani = ste;
            naslov = null;
            avtor = null;
        }

        public Knjiga(string nas, string avt, int ste)
        {
            naslov = nas;
            avtor = avt;
            steviloStrani = ste;
        }

        public Knjiga(string nas, string avt)
        {
            naslov = nas;
            avtor = avt;
            steviloStrani = 0;
        }

        public Knjiga(Knjiga G)
        {
            naslov = G.naslov;
            avtor = G.avtor;
            steviloStrani = G.steviloStrani;
        }

        public void SpremeniNaslov(string nas)
        {
            naslov = nas;
        }

        public string VrniNaslov()
        {
            return naslov;
        }
        public int SteviloStrani
        {
            get { return steviloStrani; }
            set
            {
                steviloStrani = value;
            }
        }

        public string Avtor
        {
            get { return avtor; }
            set
            {
                avtor = value;
            }
        }

        public void Izpis()
        {
            Console.WriteLine("Naslov={0}, Avtor={1}, Stevilo strani={2}", naslov, avtor, steviloStrani);
        }

    }


    class Naloga01
    {
        static void Main(string[] args)
        {
            Knjiga A = new Knjiga();    // pusti privzete vrednosti
            Knjiga B = new Knjiga(100); // nastavi stevilo strani na 100, ostale vrednosti pusti privzete
            Knjiga C = new Knjiga("S poti", "Izidor Cankar", 213);  //nastavi vse vrednosti na podane
            Knjiga D = new Knjiga("Na klancu", "Ivan Cankar");  // naslov in avtorja nastavi, stevilo strani nastavi na 0
            Knjiga E = new Knjiga(A);   // kopira podatke iz objekta A v objekt E
            Knjiga F = new Knjiga(E);

            A.SpremeniNaslov("Deseti brat");
            B.SpremeniNaslov("Martin Krpan");
            Console.Write("Naslov knjige C = " + C.VrniNaslov());
            D.SteviloStrani = 214;
            D.Avtor = "Fran Levstik";

            A.Izpis();  // izpiše podatke v objektu v obliki Naslov=xxx, Avtor=yyy, Stevilo strani=zzz
            B.Izpis();
            C.Izpis();
            D.Izpis();
            E.Izpis();
        }
    }
}
