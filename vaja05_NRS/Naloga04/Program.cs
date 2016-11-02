using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga04
{
    class Program
    {
        static void Main(string[] args)
        {

            Oseba[] A = new Oseba[20];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = new Oseba();
            }
            /** Naredite uporabniški vmesnik, ki bo vodil evidenco 20 oseb.
* Uporabnik naj ima na izbiro:
o vstavljanje podatkov za osebe,
o spreminjanje posameznih podatkov,
o izpis posameznih podatkov
o iskanje po priimku
* Program naj se izvaja v neskončni zanki.
* Uporabi razred oseba*/
            while (true)
            {
                Console.WriteLine("Izberite: ");
                Console.WriteLine("1: o vstavljanje podatkov za osebe");
                Console.WriteLine("2: o spreminjanje posameznih podatkov");
                Console.WriteLine("3: o izpis posameznih podatkov");
                Console.WriteLine("4: o iskanje po priimku");
                int a = int.Parse(Console.ReadLine());


                switch (a)
                {
                    case 1: {
                        Console.WriteLine("Izberi osebo:(0-19) ");
                        int oseba = int.Parse(Console.ReadLine());

                        for (int i = 0; i < A.Length;i++)
                        {
                            if(i ==oseba)
                            {
                                A[i] = new Oseba(Console.ReadLine(), Console.ReadLine(), Convert.ToDateTime(Console.ReadLine()));
                            }
                        }
                          
                    } break;

                    case 2: {
                        Console.WriteLine("Izberi osebo:(0-19) ");
                        int oseba = int.Parse(Console.ReadLine());

                        for (int i = 0; i < A.Length; i++)
                        {
                            if(i==oseba)
                            {
                                Console.WriteLine("Ime:");
                                A[i].Ime = Console.ReadLine();
                                Console.WriteLine("Priimek:");
                                A[i].Priimek = Console.ReadLine();
                                Console.WriteLine("Datum Rojstva:");
                                A[i].DatumRojstva = Convert.ToDateTime(Console.ReadLine());
                            }
                        }

                        

                    } break;

                    case 3: {
                        Console.WriteLine("Izberi osebo:(0-19) ");
                        int oseba = int.Parse(Console.ReadLine());

                        for (int i = 0; i < A.Length; i++)
                        {
                            if (i == oseba)
                            {
                                A[i].izpisPodatkov();
                            }
                        }
                    
                    } break;

                    case 4: {
                        for (int i = 0; i < A.Length; i++)
                        {                          
                            Console.WriteLine("Išči po priimku");
                            string priimek = Console.ReadLine();
                            string iskanaOseba;

                            for (int b = 0; b < A.Length; b++)
                            {
                                if(priimek ==A[b].Priimek)
                                {
                                    iskanaOseba = A[b].Ime;
                                    Console.WriteLine("Iskana oseba je: {0}", iskanaOseba);
                                }
                            }                           
                        }
                    
                    } break;
                }
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
            Console.WriteLine(ime + " " + priimek + ", " + "{0:MMMM,yyyy}", datumRojstva);
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
