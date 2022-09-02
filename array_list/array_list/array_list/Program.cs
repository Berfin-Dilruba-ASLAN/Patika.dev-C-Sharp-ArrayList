using System;
using System.Collections;

namespace array_list
{
    class Program
    {
        //Rastgele 10 sayının ortalamasını hesaplayıp, tek ve çift sayılarını bulup ekrana yazdıran kod.
        static void Main(string[] args)
        {
            ArrayList tekSayilar = new ArrayList();
            ArrayList ciftSayilar = new ArrayList();
            int ort = 0;
            int toplam = 0;
            Random rnd = new Random();
            for(int i = 0; i < 10; i++)
            {
                int sayi = rnd.Next(1, 100);
                Console.Write(sayi + " ");
                toplam += sayi;
                if(sayi %2 == 0)
                {
                    ciftSayilar.Add(sayi);
                }
                else
                {
                    tekSayilar.Add(sayi);
                }
            }
            Console.WriteLine();
            ort = toplam / 10;
            Console.WriteLine("Sayıların ortalaması: {0}" , ort);
            Console.WriteLine("Çift sayılar: {0}" , ciftSayilar.Count);
            Console.WriteLine("Tek sayılar: {0}" , tekSayilar.Count);
        }
    }
}
