using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety:tip güvenliği demektir.
            // do not repeat yourself!
            //kategorietiketi:değer tutucu:takma isim.
            string kategoriEtiketi = "Kategoriler"; //burayı değiştirirsek diğer sayfalarda olanları da değiştirebiliriz.
            int ogrenciSayisi = 32000; //tamsıyları tutmak içindir.
            double faizoranı = 1.45;//ondalıklı sayıları gösteririz.
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("eşittir butonu");
            }
            
            //şart blokları:
            //sisteme giriş yaptıysa "kullanıcı ayarlar butonu değil se "giriş yap butonu" yazsın.
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
          Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi); 
        }
    }
}
