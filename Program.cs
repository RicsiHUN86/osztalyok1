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
            public void ArSzamol()
            {
                double terulet = hossz * szelesseg;
                double ar = 0;

                if (tipus == "tartolap")
                    ar = terulet * TARTOLAP_AR;
                else if (tipus == "hatlap")
                    ar = terulet * HATLAP_AR;

                Console.WriteLine( $"{tipus} ({hossz * 100}x{szelesseg * 100} cm), ár: {ar} Ft");
            }

            public
            static void Main(string[] args)
            {
                Console.ReadKey();
            }
        }
    }
}
