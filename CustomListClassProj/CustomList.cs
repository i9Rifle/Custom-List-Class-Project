using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProj
{
    public class CustomList<T>
    {
        T[] items;
        int capacity;
        int count;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[4];
        }
        public void Add(T item)
        {
            items[count] = item;
            count++;
            if(count >= capacity)
            {
                capacity *= 2;
                T[] tempArray = new T[capacity];
            }
        }
    }
}
