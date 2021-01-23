using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type -> Değer tipi
            // Değer tipleri stack'de depolanır.
            // Birbirlerine değerleri üzerinden eşitlenir.
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            // Reference Type -> Referans Tipi
            // Referans tipleri heap'de depolanır. Referanslar stackde depolanırken instancelar 
            // heap'de depolanır.
            // Birbirlerine adresleri üzerinden eşitlenirler.
            // Bu yüzden eşitlenen referans tipi değiştiği zaman orijinal referans tipide değişir. 
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

        }
    }
}
