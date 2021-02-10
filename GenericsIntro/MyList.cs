using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //TYPE T'si.Bana bir tip ver ben aşağıya yapılandırırız.
    {

      T[] items; //CLASSI NEWLEDİĞİMDE T İTEMSI OLUŞTURMAM GEREKİYOR.
        //Arrayin newlenme zorunluluğu var referans tip olduğu için.
        //bir classs nwelendiğinde çalışan bloğa constructor denir.
        public MyList()
        {
            items = new T[0]; //arrayı 0 elemanlıı  olarak verdik
        }
        public void Add (T item) //t olarak ne verirsem istediğin elemanın türüde odur demektir.
        {

            T[] tempArray = items;//elemanlarım kaybolmucak buraya emanet ettim.geçici dizime.Referansı buraya tutturduk.

            items = new T[items.Length + 1];//dizinin eleman sayısını 1 arttırdık.
            //yeni new oluşturudğumuzda referans no uçar uçmasın diye referansı birine tuturmamız lazım

            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];//yukarıda temparrya tutturduğum elemanları bu kodla sırasıyla geri alıyorum.
            }
            items[items.Length - 1] = item; //itemsın son elemanı -1 değeri.
        }
       
       

    }
}

