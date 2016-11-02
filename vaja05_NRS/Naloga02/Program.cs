using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga02
{
    //random comment for GITHub
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dr = new DateTime(2001, 2, 12);
            DateTime dr2 = new DateTime(1987, 3, 2);

            Oseba A = new Oseba("Andrej","Kolobar", dr);
            Oseba B = new Oseba("Tina","Joska", dr2);

            A.Priimek = "Hlod";
            B.SpremeniIme("Jože");
            A.Ime = "Tone";

            string priimeka = A.vrniPriimek();
            string priimekb =B.Priimek;
            Console.WriteLine(priimeka + " " + priimekb);

            A.izpisPodatkov();
            B.izpisPodatkov();

            if(A.Ime == B.Ime)
            {
                Console.WriteLine("Imeni sta enako");
            }
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
