using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //construcktor olduğu için metodun dışında yazıldı.Class'ın bütün operasyonlarının erişebileceği dizi tanımlanıyor.Array olduğu için new'lememiz gerekmekte.

        //ctor tabtab construcktor oluşturduk ve new'ledik.
        public MyList()
        {
            items = new T[0];

        }
        public void Add(T item)
        {
            T[] tempArray = items;//referansın uçmaması için tempArray'e tutturuyoruz.Geçici Array
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }

            items[items.Length-1] = item;//eklenmek istenen  elemanın eklendiği yer



        }

        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }

        
    }
}
