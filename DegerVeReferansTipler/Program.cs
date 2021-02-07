using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1??
            Console.WriteLine(sayi1); //30 doğru sonuç
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); //999 doğru sonuç.
            //int,decimal, float, double, bool= değer tipleridir.(sayısal olanlar)
            //array,class,interface:referans tiptir.
            //stack ve heap alanı vardır. değer tip olanlar stackte gerçekleşir.
            //sayilar mi stackte olur new yazınca heapte yeni bi alan oluştur demek. referans tip newlemek olur.
        }
    }
}
