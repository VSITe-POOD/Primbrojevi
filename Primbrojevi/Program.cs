using System;
using System.Collections.Generic;
using System.Linq;

namespace Vsite.Pood
{
    public class Program
    {
        static void Main(string[] args)
        {
            IspišiPrimbrojeve(0);
            Console.ReadKey();
            IspišiPrimbrojeve(1);
            Console.ReadKey();
            IspišiPrimbrojeve(2);
            Console.ReadKey();
            IspišiPrimbrojeve(100);
            Console.ReadKey();
        }

        static void IspišiPrimbrojeve(int max)
        {
            Console.WriteLine("Primbrojevi do {0}:", max);
            var brojevi = GenerirajPrimBrojeve(max);
            if (brojevi.Length == 0)
                Console.WriteLine("Nema");
            else
            {
                foreach (var broj in brojevi)
                    Console.WriteLine(broj);
            }
        }
        private static bool [] neelimirani;
        private static int [] primovi;

        // Primjer iz knjige  Robert C. Martin: "Agile Software Development"!!!
        public static int[] GenerirajPrimBrojeve(int max)
        {
            if (max < 2)
                return new int[0]; // vrati prazan niz
            else
            {
                InicijalizirajNizZastavica(max);
                EliminirajVišekratnike();
                SkupiPrimove();

                return primovi; // vrati niz brojeva
            }
        }

        private static void SkupiPrimove()
        {
            List<int> prin = new List<int>();
            // prebaci primbrojeve u rezultat
            for (int i = 2; i < neelimirani.Length; ++i)
            {
                if (!neelimirani[i])
                    prin.Add(i);
            }
            primovi = prin.ToArray();
        }

        private static void EliminirajVišekratnike()
        {
            for (int i = 2; i < DajNjvećiFaktor(); ++i)
            {
                if (!neelimirani[i]) // ako i nije prekrižen, prekriži njegove višekratnike
                    EliminarjVišekratnike(i);
            }
        }

        private static int DajNjvećiFaktor()
        {
            return (int)(Math.Sqrt(neelimirani.Length) + 1);
        }

        private static void EliminarjVišekratnike(int i)
        {
            for (int j = 2 * i; j < neelimirani.Length; j += i)
                neelimirani[j] = true; // višekratnik nije primbroj
        }

        private static void InicijalizirajNizZastavica(int max)
        {
            neelimirani = new bool[max +1]; // niz s primbrojevima
        }
    }
}
