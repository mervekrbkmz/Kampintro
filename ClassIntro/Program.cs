using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "merve";
            int yas = 24;

            Kurs kurs1 = new Kurs(); //kurs değişkenin tanımladık int string gibi bunu aşağıda classa yazarak yaptık.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "merve";
            kurs1.IzlenmeOrani = "70";


            Kurs kurs2 = new Kurs(); //kurs değişkenin tanımladık int string gibi bunu aşağıda classa yazarak yaptık.
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "mustafa";
            kurs2.IzlenmeOrani = "90";

            Kurs kurs3 = new Kurs(); //kurs değişkenin tanımladık int string gibi bunu aşağıda classa yazarak yaptık.
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "ayşe";
            kurs3.IzlenmeOrani = "60";

            //   Console.WriteLine(kurs2.KursAdi+":"+ kurs2.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }


        }
    }

    class Kurs //TİP TANIMLADIK.
    {

        public string KursAdi { get; set; }
        public string  Egitmen { get; set; }
        public string IzlenmeOrani { get; set; }

    }

}
