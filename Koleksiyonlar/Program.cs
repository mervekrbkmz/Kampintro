using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            ////stack               //heap
            //string[] isimler = new string[]
            //{
            //   "Merve","Mustafa","Ayşe","Emine" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //arrayler gibi değerleri kaybetmemizi engeller.using System.Collections.Generic; bunu eklememiz gerkeir list için

            List<string> isimler2 = new List<string> { "Merve", "Mustafa", "Ayşe", "Emine" };
            Console.WriteLine( isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
          

        }

    }  
}
