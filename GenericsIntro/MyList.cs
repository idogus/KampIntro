using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        int Count;
        public MyList()
        {
            items = new T[0];
            Count = items.Length;
        }
        public void Add(T item)
        {
            Count++;
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
                items[i] = tempArray[i];

            items[items.Length] = item;
        }
    }
}
