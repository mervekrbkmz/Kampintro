using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
   class SepetManager
    {
        //manager,dal,service vs görüyorsak bunlar operasyon tutuyor demek.

        //naming convention
        //syntax:yazım şekilleri
        //methoda neyi eklememiz gerektiğini söylersek PARAMETRE olur.
        public void Ekle(Urun urun) // Urun urun kısmı parametredir ne istediğimiz yazdık.
            //methodların sytnaxı//bir yerde normal parantez varsa orada methot vardır.
        {

            Console.WriteLine("sepete eklendi : "+ urun.Adi);


        } 
        //method yazma
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int StokAdedi)
        {
            Console.WriteLine("sepete eklendi"+ urunAdi);
        }


    }
}
