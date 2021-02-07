using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1="yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";


            //array-dizi :istediğimz kadar değişkeni tek bir yerde tutabiliriz.
            //tek tek yazmak yerine yukarıdaki verileri tek bir listede tuttuk.
            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", "programlamaya başlangıç için temel kurs", "java" ,"c#"};
            //döngüler: birbirine benzeyen işlemleri tekrar etmek için kullanırız.
            for (int i = 0; i <kurslar.Length; i++) //2 2 arttır demektir. i=i+2 de olur. lenght:eleman sayısını söyler.
            {
                Console.WriteLine(kurslar[i]);//kursun(0,1,2)çalıştırır.
            }

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarar.foreach dizileri kolay dolaşmak için kullanırız. forechin içindeki kurs takma isimdir.
            {

                Console.WriteLine(kurs);

            }
            Console.WriteLine("sayfa sonu");
        }
    }
}
