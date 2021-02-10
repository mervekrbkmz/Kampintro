using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//mobilyaya karşılık gelir 2 numara.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 6, //yeni bir ürün tanımlarken bu şekilde de tanımlarız.
                ProductName = "kalem",UnitPrice=35 };

            //ürünü eklemeyi simüle etmek istersek;
            //PascalCase:Kelimlerin ilk harfi büyük. 
            //camelCase:ilk harfi küçük diğer harfleri büyük.(productManager)
            //case sensitivie:büyük küçük harfe duyarlı
            //iki kısım var :stack(ProductManager productManager) de oluşturduğumuz bu. Heap de ( new ProductManager()) oluşturduğumuz kısım da bu.
            ProductManager productManager = new ProductManager();
            //verileri(prodcut1 ve product2) alıp kullanıcıya bu şekilde gönderiririz.
            productManager.Add(product1);
    //        productManager.Topla2(2, 6);//bu işlem sonucunu başka yerde daha kullanmak istyorum.direkt sonucunu yazdırdık.
    //                                    //tekrar kulllanmamız gerektiği için return yazamamız gerekir
    //                                    //method kısmında product türünde bişey istediğimiz için buraya da product türünde eleman girmeliyiz.
    //        int toplamaSonucu = productManager.Topla(3, 6);
    //        Console.WriteLine(toplamaSonucu*2); //metodlar kısmında burası için return yapmıştık.Çünkü başka bi yerde de kullanmamız için
    //        //sayısal olanalra int,double,bool:değer tiplerdir
    //        //diziler,classlar,abstractclasslar,interfaceler:referenas tiplerdir.
    //        //classları referans tip üzerinden atıcaz.
    //    }
    //}
}
