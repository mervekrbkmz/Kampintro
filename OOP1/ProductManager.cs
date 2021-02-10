using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //Ürünle ilgili operasyonları yazarız manager kısmına---> Ekleme silme,listeleme,arama ,filtreleme ibi şeyleri içerir.
    {   //ekleme operasyonu
        public void Add(Product product) //neyi ekliceğimizi yazdık-->parametre
                                         //beni productmanager içinden çağır benim adım add.

        {
            //ürün ekliceksek neyi eklememiz gerektiğini de söylememiz gerekir.

            Console.WriteLine(product.ProductName + "Eklendi");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi");

        }
    }
}
    //    //VOİD NEDİR=GİT EKLE,GİT SİL GİT GÜNCELLE:emir kipidir.
    //    public int Topla(int sayi1,int sayi2)
    //    {
    //        return sayi1 + sayi2; //toplar int tipindedir returnd int olmak zorunda.program akışında değer bana lazım olduğu için returnu kullanırız.

    //    }
    //    public void Topla2(int sayi1, int sayi2)
    //    {
    //        Console.WriteLine(sayi1+sayi2);
    //    }
//    //}
//}
s