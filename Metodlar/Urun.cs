using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Urun
    { //string tanımladığımızda dizi içinde sadece string elemanlar kullanırız ama class yazdığımız farjlı veri tipleride kullanabiliriz.
        //ürünü sepete atıcaz.
        //classların içinde birden fazl eleman tutabilirsin
        //class nesneyi tanımlayan birden fazla bilgiyi tanımlar.

        //property:özellik(ıd,adi kısmı)
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
