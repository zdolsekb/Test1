using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ustvarite polje z imenom A za tri osebe.

* Vanj vpišite podatke (Tine Slakonja 3.11.1977, Jože Petrič 15.2.1932, Anica Tepes 4.11.2009).

* Izpišite ime tretje osebe.

* Izpišite datum prve osebe.

* Spremenite ime Jožeta v Samota

* Uporabite razred oseba*/

            DateTime dr1 = new DateTime(1977, 3, 11);
            DateTime dr2 = new DateTime(1932, 2, 15);
            DateTime dr3 = new DateTime(2009, 4, 11);

            Oseba[] A = new Oseba[3];
            A[0] = new Oseba("Tine","slakonja",dr1);
            A[1] = new Oseba("Jože", "perčič", dr2);
            A[2] = new Oseba("Anica", "Tepes", dr3);


            Console.WriteLine("{0:dddd,MMMM,yyyy}",A[0].DatumRojstva);
            A[1].Ime = "Samo";
        }

    }

    class Oseba
    {
        private string ime;
        private string priimek;
        DateTime datumRojstva;


        public Oseba()
        {
            DateTime dr = new DateTime(1977, 3, 19);
            ime = "Tine";
            priimek = "Verdev";
            datumRojstva = dr;
        }
        public Oseba(string ime, string priimek, DateTime dr)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.datumRojstva = dr;
        }

        public void SpremeniIme(string ime)
        {
            this.ime = ime;
        }

        public void SpremeniPriimek(string priimek)
        {
            this.priimek = priimek;
        }

        public void SpremeniDatumrojstva(DateTime dr)
        {
            this.datumRojstva = dr;
        }

        public string vrniIme()
        {
            return ime;
        }

        public string vrniPriimek()
        {
            return priimek;
        }

        public DateTime vrniDatumRojstva()
        {
            return datumRojstva;
        }

        public void izpisPodatkov()
        {
            Console.WriteLine(ime + " " + priimek + " " + "{0:MMMM,yyyy}", datumRojstva);
        }

        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }

        public string Priimek
        {
            get
            {
                return priimek;
            }
            set
            {
                priimek = value;
            }
        }

        public DateTime DatumRojstva
        {
            get
            {
                return datumRojstva;
            }
            set
            {
                datumRojstva = value;
            }
        }
    }
}
