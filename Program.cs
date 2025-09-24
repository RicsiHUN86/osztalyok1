using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok1
{
    internal class Program
    {
        public class Butorlap
        {
            private double hossz;
            private double szelesseg;
            private string tipus;

            public const int TARTOLAP_AR = 5000;
            public const int HATLAP_AR = 500;
            public Butorlap(string tipus, double hosszCm, double szelessegCm)
            {
                this.tipus = tipus.ToLower();
                this.hossz = hosszCm / 100.0;      
                this.szelesseg = szelessegCm / 100.0;
            }
            public double ArVisszaad()
            {
                double terulet = hossz * szelesseg;
                if (tipus == "tartolap")
                    return terulet * TARTOLAP_AR;
                else if (tipus == "hatlap")
                    return terulet * HATLAP_AR;
                else
                    return 0;
            }
            public void ArSzamol()
            {
                Console.WriteLine($"{tipus} ({hossz * 100}x{szelesseg * 100} cm), ár: {ArVisszaad()} Ft");
            }
            public class Butor
            {
                private Butorlap[] lapok;
                private int lapSzam;

                public Butor()
                {
                    lapok = new Butorlap[100];
                    lapSzam = 0;
                }
                public void LapHozzaad(Butorlap lap)
                {
                    if (lapSzam < lapok.Length)
                    {
                        lapok[lapSzam] = lap;
                        lapSzam++;
                    }
                    
                }
                public void ArSzamol2()
                {
                    double osszeg = 0;
                    for (int i = 0; i < lapSzam; i++)
                    {
                        Console.WriteLine($"{lapok[i].tipus} ({lapok[i].hossz * 100}x{lapok[i].szelesseg * 100} cm), ár: {lapok[i].ArVisszaad()} Ft");
                        osszeg += lapok[i].ArVisszaad();
                    }
                    Console.WriteLine($"Butor - lapok: {lapSzam}, ar {osszeg} Ft");
                }



            }
            static void Main(string[] args)
            {
                Butor butor = new Butor();

                Butorlap l1 = new Butorlap("tartolap", 200, 50);
                Butorlap l2 = new Butorlap("tartolap", 180, 60);
                Butorlap l3 = new Butorlap("hatlap", 200, 180);

                butor.LapHozzaad(l1);
                butor.LapHozzaad(l2);
                butor.LapHozzaad(l3);

                butor.ArSzamol2();

                Console.ReadKey();
            }
        }
    }
}
