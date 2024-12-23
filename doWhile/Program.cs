using System;

class Program
{
    static void Main(string[] args)
    {
        // While Döngüsü
        int limit;
        do
        {
            Console.WriteLine("Bir limit değeri giriniz (0 veya daha büyük bir değer giriniz):");
            limit = int.Parse(Console.ReadLine());
            if (limit < 0)
            {
                Console.WriteLine("Hata: Negatif bir değer girdiniz. Lütfen 0 veya daha büyük bir değer giriniz.");
            }
        } while (limit < 0);

        int sayac = 0;
        while (sayac <= limit)
        {
            Console.WriteLine(sayac + ". Ben bir patikalıyım.");
            sayac++;
        }

        //// Do-While Döngüsü
        //int limit2;
        //do
        //{
        //    Console.WriteLine("Bir limit değeri giriniz (0 veya daha büyük bir değer giriniz):");
        //    limit2 = int.Parse(Console.ReadLine());
        //    if (limit2 < 0)
        //    {
        //        Console.WriteLine("Hata: Negatif bir değer girdiniz. Lütfen 0 veya daha büyük bir değer giriniz.");
        //    }
        //} while (limit2 < 0);

        //int sayac2 = 0;
        //do
        //{
        //    Console.WriteLine(sayac2 + ". Ben bir patikalıyım.");
        //    sayac2++;
        //} while (sayac2 <= limit2);
    }
}
