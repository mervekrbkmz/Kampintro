using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic class??
            MyList<string> isimler = new MyList<string>();//string türünde listedir.//generic yapılara örnek.
           isimler.Add("merve");
        }
    }
}
