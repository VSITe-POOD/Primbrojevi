using System;
using System.Collections.Generic;

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

        private static bool[] neeliminirani;
        private static int[] primovi;

        // Primjer iz knjige  Robert C. Martin: "Agile Software Development"!!!
        public static int[] GenerirajPrimBrojeve(int max)
        {
            if (max < 2)
                return new int[0]; // vrati prazan niz
            else {
                InicijalizirajNizZastavica(max);
                EliminirajVisekratnike();
                SkupiPrimove();
                return primovi; // vrati niz brojeva
            }
        }

        private static void SkupiPrimove() {
            List<int> prim = new List<int>();

            // prebaci primbrojeve u rezultat
            for (int i = 2; i < neeliminirani.Length; ++i) {
                if (!neeliminirani[i])
                    prim.Add(i);
            }
            primovi = prim.ToArray();
        }

        private static void EliminirajVisekratnike() {
            for (int i = 2; i < DajNajveciFaktor()+1; ++i) {
                if (!neeliminirani[i]) // ako i nije prekrižen, prekriži njegove višekratnike
                {
                    EliminirajVisektarnike(i);
                }
            }
        }

        private static int DajNajveciFaktor() {
            return (int)(Math.Sqrt(neeliminirani.Length) + 1);
        }

        private static void EliminirajVisektarnike(int i) {
            for (int j = 2 * i; j < neeliminirani.Length; j += i)
                neeliminirani[j] = true; // višekratnik nije primbroj
        }

        private static void InicijalizirajNizZastavica(int max) {
            neeliminirani = new bool[max + 1]; // niz s primbrojevima
        }
    }
}
