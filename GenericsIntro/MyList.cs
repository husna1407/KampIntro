using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //classtan nesne oluşturulup new lendiğinde constructor method hemen çalışır ve boş list oluşur.
        public MyList()//constructor method
        {
            items = new T[0];
        }

        public void Add(T item) {    //item: eleman

            T[] tempArray = items;    //geçici array
            items = new T[items.Length+1];  //bunu yaptığımızda, aslında yeni boş bir list oluşturuyor ve eski eriler gidiyor.
            for (int i = 0; i < tempArray.Length; i++)  //bu döngü ile items içerisindeki eski değerlerine kavuştu.
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;  //method çağırıldığında parametreye verilen değeri son eleman olarak burada ekledik.
        } 

    }
}
