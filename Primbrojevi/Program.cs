using System;

namespace Vsite.Pood
{
    public class Program
    {
        static void Main(string[] args)
        {
            GenerirajPrimbrojeve(0);
            Console.ReadKey();
            GenerirajPrimbrojeve(1);
            Console.ReadKey();
            GenerirajPrimbrojeve(2);
            Console.ReadKey();
            GenerirajPrimbrojeve(100);
            Console.ReadKey();
        }

        static void GenerirajPrimbrojeve(int max)
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

        private static int s;
        private static bool[] f;
        private static int[] primovi;
        // Primjer iz knjige  Robert C. Martin: "Agile Software Development"!!!
        public static int[] GenerirajPrimBrojeve(int max)
        {
            if (max < 2)
                return new int[0]; // vrati prazan niz
            else
            {
                // deklaracije
                s = max + 1; // duljina niza
                f = new bool[s]; // niz s primbrojevima
                int i;

                // inicijaliziramo sve na true
                for (i = 0; i < s; ++i)
                    f[i] = true;

                // ukloni 0 i 1 koji su primbrojevi po definiciji
                f[0] = f[1] = false;

                // sito (ide do kvadratnog korijena maksimalnog broja)
                int j;
                for (i = 2; i < Math.Sqrt(s) + 1; ++i)
                {
                    if (f[i]) // ako i nije prekrižen, prekriži njegove višekratnike
                    {
                        for (j = 2 * i; j < s; j += i)
                            f[j] = false; // višekratnik nije primbroj
                    }
                }

                // koliko je primbrojeva?
                int broj = 0;
                for (i = 0; i < s; ++i)
                {
                    if (f[i])
                        ++broj;
                }

                primovi = new int[broj];

                // prebaci primbrojeve u rezultat
                for (i = 0, j = 0; i < s; ++i)
                {
                    if (f[i])
                        primovi[j++] = i;
                }
                return primovi; // vrati niz brojeva
            }
        }
    }
}
