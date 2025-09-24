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

            }
            static void Main(string[] args)
            {
                Console.ReadKey();
            }
        }
    }
}
