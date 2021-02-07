using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
           


            //methods:tekrar tekrar kullanılmayı sağlayan kod bloklarıdır.
            //dont repeat yourself-DRY-CLEAN CODE BEST PRATİC:DOĞRU UYGULAMA TEKNİKLERİ.

            Urun urun1 = new Urun(); //ürün tipinde classtan değişken tanımlıcağımız zaman bunu newlemek gerekir.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2}; //Array:ne kadar data eklersen o datayı tutan yapıydı.

            //classlar özellik tutar.
            //encapsulation:pek anlamadım?? ayrı ayrı yazacağın yapıyı biz düzenin içine sokmak.
            //type safe:tip güvenli:ver tipini bilmek isterim dediği için ilk başa Urun yazdık.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
            }

            Console.WriteLine("-------metotlar------------");
            

            SepetManager sepetManager = new SepetManager();  //class örneği oluşturduk(instance demek)

            sepetManager.Ekle(urun1); //ekle metotunu çağırdık.eklenin içindekiler buraya gelir diğer sayfadaki.
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "yeşil armut", 10,12);
            sepetManager.Ekle2("Elma", "yeşil elma", 10,5);

            sepetManager.Ekle2("muz", "sarı muz", 15,2);

            //metotlar bana tekrar tekrar farklı sayfalarda da kullanmayı gösterdi.



        }
    }
}
